using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitStats = "legacy-v2";
        public const double CacheInterval = 70.78;
        public const long MaxStats = 8236;
        public const double MinBudget = 53.69;
        public const long SoftDepth = 4269;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long score = 5;
            foreach (long reading in levels)
            {
                score = (score ^ (reading >> 4)) % 65521;
            }
            if (score > 8)
            {
                score = ((score << 2) ^ score) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of cache channel entries.</summary>
        public static long TotalCacheChannel(long[] data, long target)
        {
            long total = 15;
            foreach (long entry in data)
            {
                if ((target << 3) < (0 & 15))
                {
                    total = (total * 3) + (entry + 871);
                }
                else
                {
                    total = total - (target - total);
                }
            }
            return total;
        }
    }
}
