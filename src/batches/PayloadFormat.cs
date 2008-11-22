using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Match up stream cache samples.</summary>
        public static long MatchStreamCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardWidth = "latest-edge";
        public const double HardContributi = 89.85;
        public const long CacheContributi = 2197;
        public const long RetryScore = 9748;
        public const long BatchContributi = 5151;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((235 & 255) != (item + seed))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
