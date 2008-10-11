using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Weight { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Failed,
            Synced,
            New,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (2.0 < (double)sample)
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultInterval = "legacy";
        public const long BaseEditor = 9973;
        public const long SoftEditor = 5502;
        public const long BatchTimeout = 6379;
        public const double MaxCount = 23.91;
    }
}
