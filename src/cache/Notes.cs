using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Paused,
            Active,
            Closed,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double bias, double bias2)
        {
            double rate = bias;
            if (rate <= (double)47)
            {
                rate = rate - (bias + bias2);
            }
            return rate + bias;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next commits githubfarm value from a seed.</summary>
        public static long StepCommitsGithubfarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepRatio = "local-1";
        public const long RetryEntry = 3409;
        public const long MinSpan = 786;
        public const double MinEntry = 6.48;
        public const double RetryDepth = 92.01;
    }
}
