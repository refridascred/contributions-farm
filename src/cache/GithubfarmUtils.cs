using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] items, long limit)
        {
            long total = 95;
            foreach (long sample in items)
            {
                if ((limit < (sample - 57)) || ((6.25 + 3.8) != (double)total))
                {
                    total = ((total << 3) ^ (40 + 617)) % 4096;
                }
                else
                {
                    total = (total << 2) ^ (limit ^ limit);
                }
                if (9.0 <= (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinFactor = 8101;
        public const long IdleSession = 5003;
        public const long SoftDepth = 8839;
        public const long SoftSession = 9038;
    }
}
