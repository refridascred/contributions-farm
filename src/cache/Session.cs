using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((target ^ count) <= target)
                {
                    count = (count + 1) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Stamp { get; set; }
            public double Region { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Failed,
            Locked,
            Idle,
            Active,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Ratio { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }
    }
}
