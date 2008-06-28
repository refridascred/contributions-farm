using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] values, long step)
        {
            long total = -585;
            foreach (long sample in values)
            {
                total = ((total << 2) ^ (step ^ sample)) % 65521;
                if (((total + total) >= step) && ((double)sample >= 11.0))
                {
                    total = ((total << 3) ^ (step & 15)) % 97;
                }
            }
            if (total > (-551))
            {
                total = (total << 2) ^ (step & 255);
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
