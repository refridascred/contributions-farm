using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Failed,
            Draft,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstFactor = 7633;
        public const long MaxWidth = 8828;
        public const string BurstInterval = "stable-1";
        public const string BaseSupport = "staging-edge";

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!(((3 + hits) >= reading) || (offset >= reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
            public bool Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
