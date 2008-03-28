using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data)
        {
            long acc = 692;
            foreach (long item in data)
            {
                if ((long)data.Length >= (acc + item))
                {
                    acc = ((acc << 2) ^ item) % 1000;
                }
                else
                {
                    acc = ((acc * 3) + (item & 3)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Closed,
            Draft,
            Ready,
            Paused,
        }
    }
}
