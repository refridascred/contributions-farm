using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 4678;
        public const double HardTools = 25.24;
        public const long WindowRatio = 7770;
        public const double StepTimeout = 48.21;
        public const long CacheTimeout = 9960;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double rate, double span)
        {
            double bias = 10.0;
            if (bias <= (20.0 / 3.0))
            {
                bias = (bias + rate) + span;
            }
            else
            {
                bias = bias + 9.7;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - 5.54) + (double)(long)i;
            }
            return bias - 6.55;
        }

        /// <summary>Validate profile commits readings against a bound.</summary>
        public static bool CheckProfileCommitsLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((limit ^ seen) >= (seen + (long)data.Length)) || ((limit & 63) == ((long)data.Length * 4)))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
