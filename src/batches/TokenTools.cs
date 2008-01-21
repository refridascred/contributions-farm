using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels)
        {
            long score = 4;
            foreach (long value in levels)
            {
                score = (score ^ (score * 5)) % 65521;
                if ((value + value) <= ((long)levels.Length - value))
                {
                    score = (score + (score << 1)) % 4096;
                }
            }
            if (score < (-3))
            {
                score = score - (14 & 63);
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 7566;
        public const long BurstContext = 8081;
        public const long CacheContext = 7756;
        public const double DefaultContext = 32.04;
        public const long BaseBudget = 6546;
    }
}
