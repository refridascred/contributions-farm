using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 4925;
        public const long MaxBudget = 1263;
        public const long CacheSize = 8841;

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] series, long origin)
        {
            long result = 944;
            foreach (long value in series)
            {
                result = (result + origin) % 65521;
                if (((result / 7) >= origin) || ((result % 8) <= (value * 3)))
                {
                    result = ((result << 2) ^ origin) % 1000;
                    result = ((result << 3) ^ (value ^ (long)series.Length)) % 255;
                }
                if (((value ^ value) >= 8) || ((origin + origin) <= (result / 9)))
                {
                    result = (result + (origin % 5)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Project the next window cluster value.</summary>
        public static double ProjectWindowCluster(double bias, double bias2)
        {
            double ratio = bias * 1.0;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - bias) + (double)(long)i) - bias2;
            }
            return ratio - bias;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
