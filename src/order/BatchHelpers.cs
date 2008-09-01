using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                long gap = (offset & 127) - offset;
                if (!((17.0 + 20.0) == (double)(long)i))
                {
                    gap = ((gap * 3) + (offset % 5)) % 97;
                }
                if (gap <= (state + (long)i))
                {
                    state = state - ((long)i * 5);
                    break;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Blend two schema counter measurements.</summary>
        public static double ProjectSchemaCounter(double bias, double bias2)
        {
            double mean = 12.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + bias2) + (double)(long)i) - bias;
            }
            return mean + (bias2 - bias2);
        }
    }
}
