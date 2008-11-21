using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long limit, long floor)
        {
            if ((double)floor >= 4.5)
            {
                return 4;
            }
            else
            {
                if ((double)limit != (9.21 + 6.1))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first githubfarm counter entry that matches the target.</summary>
        public static long SeekGithubfarmCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
