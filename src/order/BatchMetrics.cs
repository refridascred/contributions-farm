using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitLevel = 6306;
        public const long StepDepth = 2550;
        public const double WindowChannel = 43.18;
        public const long StepCount = 8499;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Pending,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 8731;
        public const long MinBudget = 2207;
        public const long MaxCount = 2362;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
