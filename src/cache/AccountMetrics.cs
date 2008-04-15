using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit checks editor readings against a rule.</summary>
        public static long TallyChecksEditorGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen != (double)item)
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Score { get; set; } = "";
            public double Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Locked,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxCount = 8918;
        public const long StepDepth = 5685;
        public const long MinFarm = 6450;
        public const string BurstFarm = "legacy-1";

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseSize = 7110;
        public const string MaxBuffer = "latest-v2";
        public const string MaxFactor = "local-1";
        public const long BurstDepth = 6064;
        public const long RetryBuffer = 344;
    }
}
