using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Count { get; set; }
            public double Owner { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "stable";
        public const long CacheFarm = 9827;
        public const long HardDepth = 1967;
        public const long SoftDepth = 8637;
        public const double BurstLevel = 31.13;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits - 48) >= (hits + reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
