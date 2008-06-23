using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate queue cluster readings against a bound.</summary>
        public static bool CheckQueueClusterBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 4007;
        public const long BatchCommits = 7263;
        public const long BaseCommits = 3576;
        public const long WindowTimeout = 9317;

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double bias, double offset)
        {
            double mean = offset;
            if (mean >= (offset - bias))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + offset) - (double)(long)i;
            }
            return mean - bias;
        }
    }
}
