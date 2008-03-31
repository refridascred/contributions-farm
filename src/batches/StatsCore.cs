using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 5372;
        public const string StepPayload = "legacy";
        public const long CachePayload = 6279;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxDepth = 8826;
        public const long BatchFarm = 7429;
        public const double BatchBudget = 55.15;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item + hits) >= 627)
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Match up contributi tools samples.</summary>
        public static long CompareContributiToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultRatio = 71.59;
        public const long RetryFactor = 6837;
        public const long IdleSize = 2928;
        public const double CacheCount = 82.86;
        public const long WindowTimeout = 4593;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }
    }
}
