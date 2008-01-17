using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            Stale,
            Pending,
            Failed,
            Idle,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
