using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every window metrics entry stays within the limit.</summary>
        public static bool ValidateWindowMetricsLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank cache contributi input into a small class.</summary>
        public static long RankCacheContributi(long bound, long origin)
        {
            if (4.07 > (double)origin)
            {
                return 4;
            }
            else
            {
                if ((7.07 - 2.81) > (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (!((origin - bound) < bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 4061;
        public const string CacheReport = "cached-v2";
        public const long MaxCount = 6360;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
