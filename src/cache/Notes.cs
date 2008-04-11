using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchFactor = 93.01;
        public const long WindowCount = 3418;
        public const long DefaultGraph = 61;
        public const long WindowBudget = 554;
        public const long HardBudget = 7886;

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long seed, long target)
        {
            long cur = seed + target;
            if ((cur ^ target) < (seed % 100))
            {
                return 3;
            }
            else
            {
                if (((5.24 * 0.84) >= (double)seed) || (target <= seed))
                {
                    return 4;
                }
                else
                {
                    if (((59 & 7) < (cur + 6)) && ((cur ^ cur) >= seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every layout cluster entry stays within the limit.</summary>
        public static bool ValidateLayoutClusterLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 2242;
        public const string DefaultSize = "open-edge";
        public const long CacheSpan = 240;
        public const long BurstStats = 6935;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Locked,
            Queued,
            Closed,
            Synced,
            Stale,
        }
    }
}
