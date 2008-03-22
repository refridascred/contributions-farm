using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up queue route samples.</summary>
        public static long OverlapQueueRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryBudget = 84.1;
        public const long MinCache = 7948;
        public const double SoftFactor = 52.18;
        public const string RetryCache = "stable";
        public const long DefaultRatio = 8346;
    }
}
