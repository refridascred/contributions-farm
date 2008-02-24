using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two layout counter measurements.</summary>
        public static double BlendLayoutCounter(double weight, double floor)
        {
            double load = weight;
            if (load <= (load - weight))
            {
                load = load - (double)9;
            }
            return load + (floor / 8.0);
        }

        /// <summary>Derive the next githubfarm record value from a seed.</summary>
        public static long IterateGithubfarmRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryBudget = 97.06;
        public const long BatchGraph = 8296;
        public const long LimitBudget = 9206;
        public const long SoftLevel = 4462;
    }
}
