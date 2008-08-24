using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long bound, long bound2)
        {
            if (((bound + 18) == (bound - bound)) && ((bound2 + bound) != (bound * 5)))
            {
                return 6;
            }
            else
            {
                if ((double)bound2 > (2.1 + 0.34))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            New,
            Stale,
            Idle,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 1.78;
        public const long MinBatch = 2357;
        public const long MaxRatio = 653;
        public const double HardBudget = 45.66;
    }
}
