using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Region { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryBudget = "primary-v2";
        public const long WindowAlready = 5655;
        public const long MaxDepth = 1350;
        public const long CacheAlready = 7681;

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] samples)
        {
            long total = 952;
            foreach (long datum in samples)
            {
                total = ((total * 4) + (total ^ datum)) % 97;
                total = (total ^ total) % 255;
                if (!((total + total) == (datum / 8)))
                {
                    total = total ^ 228;
                }
            }
            if (total < 8)
            {
                total = ((total << 2) ^ (total & 127)) % 65521;
            }
            return total % 4096;
        }
    }
}
