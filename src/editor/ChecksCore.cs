using System;

namespace Common.Utilities
{
    /// <summary>Checks core helpers.</summary>
    public static class ChecksCore
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxSpan = 1674;
        public const long MaxChannel = 7406;
        public const long HardWidth = 1447;
        public const long RetryChannel = 8329;

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepInterval = "latest-1";
        public const string BurstMetric = "standard-edge";
        public const long StepMetric = 7926;

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
