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

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryContext = 83.03;
        public const string LimitContext = "strict-1";
        public const long BaseContext = 5096;
        public const long DefaultContext = 5426;
        public const long RetryDepth = 6164;

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
