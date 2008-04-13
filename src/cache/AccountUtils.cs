using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long seed)
        {
            if (seed >= (seed - seed))
            {
                return 3;
            }
            else
            {
                if ((seed * 3) < (origin + seed))
                {
                    return 8;
                }
                else
                {
                    if (17.0 < (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double bias, double floor)
        {
            double mean = bias;
            if (mean >= floor)
            {
                mean = mean + (mean + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] samples, long bound)
        {
            long score = 554;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length % 16) != (bound % 97)) && (bound >= (bound >> 1)))
                {
                    score = (score - entry) % 65521;
                }
            }
            return score;
        }
    }
}
