using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
