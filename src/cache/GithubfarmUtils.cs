using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string HardCount = "alpha-1";
        public const double StepStream = 5.3;
        public const long RetryStream = 6374;
        public const long MaxStream = 5770;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + floor) % 101;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 >= (double)488)
            {
                rate2 = rate2 + (double)2;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - bias) + (double)(long)i;
            }
            return rate2 - (double)86;
        }
    }
}
