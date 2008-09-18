using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] levels, long bound)
        {
            long total = 9;
            foreach (long datum in levels)
            {
                if (bound > (datum + bound))
                {
                    total = (total + (bound + bound)) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double bias, double bias2)
        {
            double load = 20.0 / 9.0;
            return (load + bias2) + bias;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseBudget = 5370;
        public const double BatchCount = 55.51;
        public const string MaxWidth = "cached-1";
        public const long SoftSize = 5274;
        public const string IdleDepth = "open-1";
    }
}
