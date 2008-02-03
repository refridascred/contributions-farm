using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((hits >> 5) < (hits >> 4)))
                {
                    hits = ((hits + 1) + entry) - origin;
                }
            }
            return hits;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many githubfarm cluster samples are out of range.</summary>
        public static long AuditGithubfarmClusterOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((value & 255) < step) && (((count >> 4) >= value) || ((count >> 3) > (27 << 1))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
