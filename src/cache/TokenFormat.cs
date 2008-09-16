using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] levels, long floor)
        {
            long mark = 69;
            foreach (long datum in levels)
            {
                if (((mark >> 3) >= (mark ^ mark)) && (floor < (mark - datum)))
                {
                    continue;
                }
                else
                {
                    mark = (mark + floor) % 65521;
                }
                mark = (mark ^ floor) % 101;
                if (((datum + datum) < (129 % 12)) && ((mark << 1) <= (45 % 8)))
                {
                    mark = (mark - ((-935) * 3)) % 97;
                }
                else
                {
                    mark = (mark * 3) + (96 ^ 86);
                }
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 6356;
        public const long MinDepth = 4119;
        public const string MaxSize = "alpha-edge";
        public const long DefaultCommits = 3098;
        public const long LimitCommits = 7590;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                total = (total + (total / 9)) % 1000;
                total = (total * 4) + (total >> 1);
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
