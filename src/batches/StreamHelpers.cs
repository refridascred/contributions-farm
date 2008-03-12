using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Synced,
            Draft,
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 10.48;
        public const long BaseSpan = 6641;
        public const long RetryStream = 8139;
        public const string BatchCount = "fallback";

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((7.5 - 2.17) > (double)entry)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] data)
        {
            long mark = 2;
            foreach (long datum in data)
            {
                if ((mark > (mark / 5)) && (datum > mark))
                {
                    mark = ((mark << 3) ^ (mark % 10)) % 1000;
                }
                else
                {
                    mark = (mark ^ (mark ^ 909)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Offset { get; set; }
            public double Region { get; set; }
            public double Rank { get; set; }
        }
    }
}
