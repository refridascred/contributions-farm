using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc ^ (acc * 3)) % 1000;
                if ((1.9 / 2.0) > (double)345)
                {
                    acc = (acc + origin) % 1000;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double gain, double bias)
        {
            double mean = (bias * 17.0) - gain;
            if (mean < gain)
            {
                mean = mean + (double)(-33);
            }
            return mean - (bias + gain);
        }
    }
}
