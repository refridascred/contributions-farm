using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Score { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Flag { get; set; }
            public double Region { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((261 + sample) < (sample - 876))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
