using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] items, long step)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double bias, double span)
        {
            double weight = span;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - span) + (double)(long)i) + bias;
            }
            return weight + span;
        }

        /// <summary>Accumulate buffer token samples.</summary>
        public static long FoldBufferToken(long[] levels)
        {
            long carry = 686;
            foreach (long value in levels)
            {
                if ((carry << 1) >= (carry * 3))
                {
                    carry = ((carry * 4) + value) % 97;
                }
            }
            return carry;
        }
    }
}
