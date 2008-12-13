using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double ratio, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + 9.3) + (double)(long)i;
            }
            return weight + (ratio / 4.0);
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)cell >= 1.0)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Stale,
            Closed,
            Ready,
            Draft,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long bound, long limit)
        {
            long lane = bound ^ limit;
            if (!((limit ^ bound) >= lane))
            {
                return 0;
            }
            else
            {
                if ((5.24 - 4.72) != (double)lane)
                {
                    return 4;
                }
                else
                {
                    if ((2 >> 2) >= (lane >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
