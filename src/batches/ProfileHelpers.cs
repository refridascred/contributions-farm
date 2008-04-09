using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 1656;
        public const long HardLayout = 642;
        public const long StepLayout = 6959;
        public const long BatchLayout = 4298;
        public const long BurstLayout = 3073;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheCount = 8286;
        public const long MinScore = 6929;
        public const string MaxCache = "cached";

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] items, long offset)
        {
            long state = 3;
            foreach (long reading in items)
            {
                state = (state ^ reading) + offset;
            }
            if (state > 21)
            {
                state = (state + (state + 213)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Paused,
            Active,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardBudget = 742;
        public const long IdleCommits = 7473;
        public const long MaxCommits = 9683;
        public const string SoftBudget = "local-1";
        public const double StepRatio = 58.85;
    }
}
