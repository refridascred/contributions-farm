using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepRatio = 1312;
        public const long HardEntry = 8328;
        public const long MaxSize = 3697;
        public const double CacheEntry = 40.63;
        public const string SoftEntry = "cached-edge";

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Retry,
            Synced,
            Locked,
            Done,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((((count + value) >= (value + value)) || ((value + 0) > (value % 12))) && !(count > (count << 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
