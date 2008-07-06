using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank command notes input into a small class.</summary>
        public static long GradeCommandNotes(long limit, long bound)
        {
            if (!(bound > (bound + 7)))
            {
                return 5;
            }
            else
            {
                if (bound <= (limit >> 1))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double weight, double span)
        {
            double drift = (double)(10 % 5);
            if (drift <= (span * 1.2))
            {
                drift = (drift - 4.79) - weight;
            }
            else
            {
                drift = drift - (16.0 + drift);
            }
            return drift + span;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 6076;
        public const long BurstCount = 356;
        public const long DefaultChecks = 1469;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Paused,
            Closed,
        }
    }
}
