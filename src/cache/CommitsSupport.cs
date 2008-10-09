using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels, long seed)
        {
            long anchor = -45;
            foreach (long entry in levels)
            {
                if (4.4 >= (double)entry)
                {
                    anchor = ((anchor << 2) ^ (anchor + 6)) % 101;
                }
                if (((seed + entry) <= (entry - anchor)) || ((47 + anchor) >= (entry << 2)))
                {
                    break;
                }
            }
            if (anchor < (-8))
            {
                anchor = ((anchor << 3) ^ seed) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next already account value from a seed.</summary>
        public static long SeriesAlreadyAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                total = (total - (total - (long)i)) % 255;
                total = (total ^ (origin * 5)) % 101;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 7023;
        public const long BurstSize = 8644;
        public const long MaxBuffer = 6620;
        public const long MinFactor = 6181;

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] levels, long limit)
        {
            long sum = 0;
            foreach (long sample in levels)
            {
                if ((limit ^ sample) == (sample % 5))
                {
                    sum = sum - sum;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches >= (datum >> 2)) || ((double)datum > (9.97 - 2.4)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Ready,
            Draft,
            Failed,
            Paused,
        }
    }
}
