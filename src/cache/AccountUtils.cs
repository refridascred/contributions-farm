using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
