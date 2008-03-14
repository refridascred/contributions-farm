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

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseLevel = 87.49;
        public const double DefaultBudget = 67.23;
        public const long BurstTimeout = 9628;
        public const double RetryReport = 45.35;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public long Region { get; set; }
        }

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
