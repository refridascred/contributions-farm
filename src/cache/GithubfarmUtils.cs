using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a route support counter forward.</summary>
        public static long StepRouteSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + ((long)i - (long)i)) % 1000;
                acc = (acc << 3) ^ (acc ^ (long)i);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double weight, double span)
        {
            double gain = (span * 1.0) + 12.0;
            if (gain > weight)
            {
                gain = gain - (span / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (4.77 * 7.6)) + (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseRatio = 5883;
        public const string StepScore = "legacy";
        public const string MinStats = "staging-v2";
        public const double MaxRatio = 67.15;
        public const double BatchSpan = 95.14;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Active,
            Draft,
            Stale,
            Dropped,
            Closed,
        }
    }
}
