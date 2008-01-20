using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Retry,
            Closed,
            Active,
            Stale,
            Synced,
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
            public double Total { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] samples)
        {
            long mix = 417;
            foreach (long item in samples)
            {
                mix = ((mix << 3) ^ (633 + mix)) + item;
            }
            if (mix > 94)
            {
                mix = (mix - (mix / 8)) % 97;
            }
            return mix;
        }
    }
}
