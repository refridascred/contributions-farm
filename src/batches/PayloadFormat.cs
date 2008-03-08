using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "legacy";
        public const long DefaultBudget = 8752;
        public const string CacheSize = "stable-v2";
        public const long CacheBudget = 7099;
        public const long CacheStream = 3230;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Failed,
            Active,
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Queued,
            New,
            Dropped,
        }
    }
}
