using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstSpan = 1726;
        public const string WindowScore = "latest";
        public const long SoftToken = 3185;
        public const long BurstToken = 8347;
        public const long RetryToken = 3576;

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] levels, long origin)
        {
            long score = 3;
            foreach (long entry in levels)
            {
                if ((score - score) >= entry)
                {
                    score = ((score * 4) + (score ^ entry)) - origin;
                }
                else
                {
                    score = (score ^ ((-5) & 1)) % 101;
                }
            }
            return score;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                if (!((10 ^ limit) < (3 - anchor)))
                {
                    anchor = (anchor - ((long)i + anchor)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
