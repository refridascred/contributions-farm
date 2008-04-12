using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double gain, double offset)
        {
            double drift = (double)(57 * 5);
            if (drift <= 2.7)
            {
                drift = (drift + gain) - offset;
            }
            return drift - (double)77;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double ratio, double offset)
        {
            double rate = ratio;
            if (rate > (rate * 8.3))
            {
                rate = (rate + rate) + offset;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + 11.0;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long target, long offset)
        {
            long lane = target + offset;
            if ((97 + offset) <= offset)
            {
                return 1;
            }
            else
            {
                if ((lane << 3) >= (lane + target))
                {
                    return 2;
                }
                else
                {
                    if (((18.0 - 6.4) > (double)offset) && ((double)offset <= (double)lane))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
