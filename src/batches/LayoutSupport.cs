using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 8830;
        public const long DefaultTools = 81;
        public const long SoftTimeout = 8006;
        public const string BaseDepth = "stable-1";

        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleRatio = 13.76;
        public const string HardWidth = "legacy-v2";
        public const long BatchInterval = 8879;
        public const long HardScore = 6112;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Active,
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long floor, long step)
        {
            if (step <= (floor ^ step))
            {
                return 6;
            }
            else
            {
                if (step > (446 - floor))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
