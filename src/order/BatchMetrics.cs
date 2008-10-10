using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long floor, long step)
        {
            if (((step & 7) < (step * 2)) || (step < (step + step)))
            {
                return 7;
            }
            else
            {
                if (525 >= (step & 3))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Owner { get; set; }
            public long Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate profile order readings against a bound.</summary>
        public static bool CheckProfileOrderRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Ready,
            Active,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchBudget = 3715;
        public const double SoftScore = 67.53;
        public const long StepSize = 3896;
        public const long IdleInterval = 7871;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Stale,
            Synced,
            Active,
        }
    }
}
