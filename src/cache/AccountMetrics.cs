using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public string Score { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((4.72 - 6.68) >= (double)bound)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleBudget = 3390;
        public const long BurstCluster = 3853;
        public const string DefaultSpan = "legacy-v2";
        public const long MinDepth = 9379;

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 3399;
        public const long LimitRoute = 7574;
        public const double MinRoute = 8.08;
        public const long SoftScore = 4989;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Closed,
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Paused,
            Stale,
            Failed,
            Ready,
        }
    }
}
