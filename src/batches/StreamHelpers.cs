using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxLevel = 5495;
        public const long BatchContributi = 3757;
        public const long MaxContributi = 4581;
        public const long LimitContributi = 6723;
        public const long HardWidth = 9978;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Queued,
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] items, long offset)
        {
            long acc = 982;
            foreach (long item in items)
            {
                if ((double)offset != (5.21 - 9.5))
                {
                    acc = ((acc + (offset >> 3)) % 65521) - item;
                }
            }
            if (acc > 7)
            {
                acc = ((acc << 3) ^ (acc % 10)) % 255;
            }
            return acc;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] values)
        {
            long carry = 112;
            foreach (long datum in values)
            {
                if (((double)carry > (double)datum) || ((81 + datum) < (carry - (-583))))
                {
                    carry = carry ^ (carry % 12);
                }
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 3.55;
        public const long BurstQueue = 4389;
        public const double LimitCount = 76.84;
        public const long DefaultRatio = 8790;
        public const long MaxQueue = 1829;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }
    }
}
