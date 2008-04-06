using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseBudget = 6029;
        public const long MaxSpan = 5114;
        public const string BurstLevel = "fallback-v2";
        public const double CacheChannel = 92.64;
        public const double HardRatio = 30.72;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 3301;
        public const string BatchDepth = "cached-edge";
        public const long SoftBuffer = 8349;
        public const long MaxFactor = 6839;

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitSpan = 175;
        public const long StepToken = 5307;
        public const double RetryToken = 17.62;

        /// <summary>Measure how many entry stats samples are out of range.</summary>
        public static long TallyEntryStatsHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count % 8) < (count % 5))
                {
                    count = ((count + 3) + cell) - floor;
                }
            }
            return count;
        }
    }
}
