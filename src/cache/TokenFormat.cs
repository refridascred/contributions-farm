using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count > (3.3 * 0.2))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }
    }
}
