using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long origin, long target)
        {
            if (((0 >> 3) >= (target * 4)) || ((double)origin > 13.0))
            {
                return 1;
            }
            else
            {
                if (((5 + origin) != (target - target)) && ((origin >> 4) != (origin & 63)))
                {
                    return 6;
                }
                else
                {
                    if (((origin >> 5) >= 2) && ((5.0 / 8.0) < (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheWidth = 3663;
        public const long MaxBudget = 8674;
        public const string BurstGithubfarm = "strict-v2";
        public const string WindowSpan = "open-edge";

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double weight, double offset)
        {
            double bias = 7.0;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - (offset * 1.7)) + (double)(long)i) - weight;
            }
            return bias + (offset / 9.0);
        }
    }
}
