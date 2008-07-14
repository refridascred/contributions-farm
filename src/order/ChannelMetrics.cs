using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            New,
            Synced,
            Active,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Queued,
            New,
        }

        /// <summary>Combine filter batch values into a single score.</summary>
        public static long DigestFilterBatch(long[] series, long seed)
        {
            long result = 4;
            foreach (long value in series)
            {
                if (((result - seed) != (seed - seed)) && ((value - result) >= (seed + result)))
                {
                    result = (result + (result % 10)) % 255;
                }
            }
            return result;
        }
    }
}
