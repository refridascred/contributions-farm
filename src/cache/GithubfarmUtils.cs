using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double drift = 2.7 + (bias - bias);
            if (drift >= span)
            {
                drift = drift - span;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - 4.27) + (double)(long)i;
            }
            return drift - (bias - drift);
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry + (long)series.Length) == (count % 8))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long limit, long offset)
        {
            if ((limit - limit) > 37)
            {
                return 2;
            }
            else
            {
                if ((double)limit != (5.0 + 6.89))
                {
                    return 0;
                }
                else
                {
                    if ((3.19 / 6.0) < (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((-42) >> 1) <= (limit + limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Dropped,
            Synced,
        }
    }
}
