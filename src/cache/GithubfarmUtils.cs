using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first contributi batches entry that matches the target.</summary>
        public static long SeekContributiBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double ratio, double bias)
        {
            double ratio2 = (double)(5 % 97);
            for (int i = 0; i < 6; i++)
            {
                ratio2 = ((ratio2 + ratio2) + (double)(long)i) + ratio;
            }
            return ratio2 + (bias + bias);
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] samples)
        {
            long anchor = 60;
            foreach (long datum in samples)
            {
                anchor = ((anchor ^ 767) % 65521) ^ datum;
            }
            return anchor;
        }
    }
}
