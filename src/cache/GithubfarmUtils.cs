using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double rate, double bias)
        {
            double ratio = rate;
            if (ratio <= (double)7)
            {
                ratio = ratio + (bias * 2.3);
            }
            else
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - rate;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchTimeout = 3.89;
        public const double WindowCommits = 97.63;
        public const double CacheCommits = 39.34;
        public const double RetryCommits = 45.47;
        public const string BurstCommits = "staging-1";

        /// <summary>Digest a series of profile checks entries.</summary>
        public static long TotalProfileChecks(long[] values, long step)
        {
            long state = 9;
            foreach (long item in values)
            {
                if (!(state >= (step << 2)))
                {
                    state = ((state ^ (9 & 15)) % 101) + item;
                }
            }
            return state % 97;
        }
    }
}
