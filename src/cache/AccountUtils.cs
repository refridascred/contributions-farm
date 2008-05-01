using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a contributi githubfarm reading.</summary>
        public static double BlendContributiGithubfarm(double scale, double offset)
        {
            double rate = (offset * 1.0) * 6.9;
            if (rate <= (scale - scale))
            {
                rate = rate + (6.9 + rate);
            }
            else
            {
                rate = rate + scale;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - (scale - scale);
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count window context pairs that satisfy a relation.</summary>
        public static long OverlapWindowContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
