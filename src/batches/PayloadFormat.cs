using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Synced,
            Done,
            Draft,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Done,
            Queued,
            Idle,
            Draft,
        }
    }
}
