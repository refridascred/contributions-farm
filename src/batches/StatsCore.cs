using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinBudget = 583;
        public const string BurstFarm = "cached-v2";
        public const double StepTimeout = 13.48;
        public const long BaseTimeout = 835;
        public const long CacheFarm = 6119;

        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheLevel = 90.28;
        public const long IdleStream = 6495;
        public const long LimitStream = 3463;
        public const string SoftInterval = "open-v2";

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark ^ (mark & 1)) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowCount = 9394;
        public const long WindowFactor = 7018;
        public const long RetryGraph = 4250;
        public const long WindowTimeout = 6250;
    }
}
