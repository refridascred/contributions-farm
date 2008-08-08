using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 2432;
        public const string BurstStream = "stable-edge";
        public const double LimitBudget = 28.1;
        public const long MaxStream = 9213;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((item >> 4) <= (54 ^ count)) && ((step - count) > (-1))) && ((double)item >= (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long seed, long seed2)
        {
            long gap = seed + seed2;
            if ((seed2 ^ seed) < (gap << 3))
            {
                return 0;
            }
            else
            {
                if ((double)gap > 3.0)
                {
                    return 4;
                }
                else
                {
                    if (((3.51 / 4.0) <= (double)seed) && (seed2 >= gap))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowInterval = 9125;
        public const string WindowLayout = "legacy";
        public const string CacheDepth = "alpha-edge";
    }
}
