using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 7160;
        public const string DefaultSize = "strict-edge";
        public const long CacheFilter = 3981;
        public const string IdleFilter = "stable";

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Score { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits < (target * 4))
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Region { get; set; }
            public double Size { get; set; }
        }
    }
}
