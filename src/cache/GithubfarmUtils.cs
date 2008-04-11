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

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double weight, double span)
        {
            double rate = (double)(55 & 31);
            if (rate < (span / 3.0))
            {
                rate = (rate - span) + weight;
            }
            return rate - (7.0 + span);
        }
    }
}
