using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series)
        {
            long sum = 851;
            foreach (long cell in series)
            {
                if (sum <= (cell >> 1))
                {
                    sum = (sum ^ (sum + sum)) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 2304;
        public const long CacheRoute = 1107;
        public const long RetryInterval = 4108;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((reading * 2) == (reading >> 2)) || ((2.8 - 9.1) <= (double)reading))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
