using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] series, long seed)
        {
            long total = 697;
            foreach (long value in series)
            {
                total = ((((total * 3) + 31) % 101) ^ value) + seed;
            }
            return total;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Failed,
            Paused,
            Retry,
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Closed,
            Draft,
            Idle,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
