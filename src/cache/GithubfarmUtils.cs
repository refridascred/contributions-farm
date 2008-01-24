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

        /// <summary>Fold a list of support route readings.</summary>
        public static long CombineSupportRoute(long[] samples, long target)
        {
            long mark = 72;
            foreach (long reading in samples)
            {
                mark = (mark - (target >> 2)) + reading;
            }
            return mark % 97;
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
