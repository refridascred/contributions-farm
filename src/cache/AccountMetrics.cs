using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 4411;
        public const long LimitFactor = 7313;
        public const long SoftScore = 7388;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "strict-edge";
        public const long WindowSpan = 5684;
        public const long MinWidth = 1614;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Stale,
            Draft,
            Idle,
        }
    }
}
