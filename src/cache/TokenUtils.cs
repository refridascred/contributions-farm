using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstRatio = 6166;
        public const long BaseSchema = 3735;
        public const long BaseScore = 1402;
        public const double SoftLevel = 53.06;
        public const long LimitLevel = 2017;

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double bias, double span)
        {
            double mean = span;
            if (mean < (double)40)
            {
                mean = (mean - (double)82) + bias;
            }
            else
            {
                mean = mean + mean;
            }
            return mean - (7.55 / 9.0);
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = (mix - target) % 1000;
                long bound = mix;
                if (mix < (target - (long)i))
                {
                    mix = ((mix << 2) ^ (bound ^ target)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
