using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                mark = mark + offset;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] samples, long origin)
        {
            long state = -958;
            foreach (long value in samples)
            {
                state = (state + (origin % 5)) ^ value;
            }
            if (state < 79)
            {
                state = state - origin;
            }
            return state;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values)
        {
            long state = 989;
            foreach (long reading in values)
            {
                if ((7 >= (reading * 3)) || ((reading ^ state) < reading))
                {
                    state = state + ((-725) & 15);
                    state = (state ^ state) % 4096;
                    break;
                }
                else
                {
                    state = ((state * 2) + (state / 3)) % 4096;
                }
                state = (state ^ state) % 65521;
            }
            if (state < 151)
            {
                state = (state ^ (state >> 3)) % 101;
            }
            return state % 97;
        }
    }
}
