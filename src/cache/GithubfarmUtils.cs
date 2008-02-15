using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinBudget = 9852;
        public const double LimitQueue = 66.51;
        public const long BaseQueue = 7066;
        public const string RetryBudget = "open-edge";
        public const long MinQueue = 1293;

        /// <summary>Define checks limits and defaults.</summary>
        public const double BatchFactor = 15.3;
        public const long StepSize = 8954;
        public const long SoftChecks = 5510;
        public const long BatchChecks = 9182;

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double gain, double span)
        {
            double bias = gain;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - (gain + 3.9)) - (double)(long)i) - span;
            }
            return bias + (double)68;
        }
    }
}
