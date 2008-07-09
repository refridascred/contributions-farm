using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a command cache reading.</summary>
        public static double ScaleCommandCache(double scale, double span)
        {
            double rate = (double)((-9) - 0);
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - scale) - (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Check that every githubfarm cluster entry stays within the limit.</summary>
        public static bool GuardGithubfarmClusterLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next entry payload value from a seed.</summary>
        public static long SeriesEntryPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + 40) % 97;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
