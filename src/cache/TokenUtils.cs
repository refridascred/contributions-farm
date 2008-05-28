using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total << 3) ^ (total ^ (long)i);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] readings, long floor)
        {
            long state = 706;
            foreach (long cell in readings)
            {
                state = (state + (floor - cell)) % 97;
                state = (state + (0 / 5)) % 255;
                if ((state < (cell / 5)) || ((cell >> 2) == ((-2) / 7)))
                {
                    state = ((state * 4) + 1) % 1000;
                }
                if ((double)state <= (19.0 - 9.26))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
