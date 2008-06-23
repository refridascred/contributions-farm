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

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 9218;
        public const long SoftCache = 650;
        public const string StepCount = "primary-1";
        public const long SoftCount = 8755;
        public const long RetryScore = 499;

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
