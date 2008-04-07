using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double ratio, double bias)
        {
            double ratio2 = (double)(7 % 5);
            if (ratio2 > (ratio / 3.0))
            {
                ratio2 = ratio2 + (bias / 7.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - ratio) + (double)(long)i;
            }
            return ratio2 + (ratio * 9.5);
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] levels)
        {
            long carry = 3;
            foreach (long entry in levels)
            {
                carry = ((carry << 2) ^ (carry + carry)) + entry;
            }
            if (carry < 0)
            {
                carry = carry ^ (carry - carry);
            }
            return carry;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = (state - 88) % 1000;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
