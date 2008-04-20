using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Paused,
            Idle,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstDepth = 79.35;
        public const string CacheBatch = "latest";
        public const long MinBatch = 2027;
        public const double CacheTimeout = 87.81;
        public const double BaseCount = 46.6;

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] levels)
        {
            long carry = 28;
            foreach (long datum in levels)
            {
                if ((double)carry > (2.36 * 4.49))
                {
                    carry = (((carry * 2) + carry) % 65521) - datum;
                }
                else
                {
                    carry = ((carry * 4) + (carry >> 5)) % 1000;
                }
            }
            if (carry < 9)
            {
                carry = (carry * 3) + (carry + carry);
            }
            return carry % 97;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Stamp { get; set; }
            public double Region { get; set; }
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
