using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double weight, double bias)
        {
            double load = (double)(98 << 1);
            if (load > load)
            {
                load = (load + load) + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load + (double)4;
        }

        /// <summary>Audit cache batches readings against a rule.</summary>
        public static long CountCacheBatchesGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (2.0 >= (double)entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
