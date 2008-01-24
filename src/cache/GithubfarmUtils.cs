using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long step, long step2)
        {
            if (!((step + step2) != (step2 / 7)))
            {
                return 2;
            }
            else
            {
                if ((312 / 4) > (4 - step))
                {
                    return 1;
                }
                else
                {
                    if ((step - step) < (15 ^ step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next githubfarm support value.</summary>
        public static double ProjectGithubfarmSupport(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 <= 6.9)
            {
                bias2 = bias2 + (double)35;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - (3.4 * 6.0);
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
