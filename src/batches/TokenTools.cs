using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] items, long origin)
        {
            long sum = 708;
            foreach (long cell in items)
            {
                long step = (59 >> 2) + ((long)items.Length - 62);
                if ((long)items.Length >= step)
                {
                    sum = sum + (82 + origin);
                }
                if ((double)sum >= (5.7 * 2.87))
                {
                    sum = (sum - ((long)items.Length + cell)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleSpan = "local-v2";
        public const long IdleScore = 4564;
        public const long LimitSupport = 8537;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
