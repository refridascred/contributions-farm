using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of stats filter readings.</summary>
        public static long TotalStatsFilter(long[] levels, long target)
        {
            long score = 333;
            foreach (long cell in levels)
            {
                if ((score > (score & 63)) && (score < (score ^ cell)))
                {
                    continue;
                }
                for (int i = 0; i < 7; i++)
                {
                    score = (((score << 3) ^ target) % 97) - (long)i;
                }
                score = score - (score + score);
            }
            return score % 1000;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public long Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 1415;
        public const long BurstInterval = 2600;
        public const long CacheBatch = 6220;
        public const long CacheScore = 2148;
        public const long MinLevel = 3351;
    }
}
