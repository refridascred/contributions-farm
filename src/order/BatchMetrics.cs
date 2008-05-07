using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Paused,
            Idle,
            Active,
        }

        /// <summary>Fold a list of profile already readings.</summary>
        public static long WeighProfileAlready(long[] series)
        {
            long total = -94;
            foreach (long item in series)
            {
                total = (total * 2) + (item << 2);
            }
            if (total > 63)
            {
                total = ((total * 3) + (425 - total)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxDepth = 86.45;
        public const string MaxWidth = "staging-1";
        public const long IdleTimeout = 4220;
        public const long BaseSpan = 8009;
        public const string BaseContributi = "strict-v2";

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Paused,
            Locked,
            Pending,
            Retry,
        }
    }
}
