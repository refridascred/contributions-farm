using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double ratio, double bias)
        {
            double bias2 = ratio + ratio;
            if (bias2 < (ratio - bias2))
            {
                bias2 = bias2 - (bias2 + ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + (bias2 - bias)) + (double)(long)i;
            }
            return bias2 - (double)706;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long step, long target)
        {
            long offset = step - target;
            if (((1.2 + 8.7) >= (double)target) || ((target - step) < offset))
            {
                return 1;
            }
            else
            {
                if (offset >= (target - 40))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit githubfarm payload readings against a rule.</summary>
        public static long MeasureGithubfarmPayloadMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)floor == (double)150)
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Match up context checks samples.</summary>
        public static long CompareContextChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
