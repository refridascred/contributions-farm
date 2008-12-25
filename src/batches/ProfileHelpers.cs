using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double rate, double bias)
        {
            double mean = 12.0;
            return ((mean - 4.0) + rate) + bias;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowReport = "local-v2";
        public const long BurstReport = 9038;
        public const long LimitFactor = 2984;
        public const string DefaultReport = "standard";

        /// <summary>Project the next format channel value.</summary>
        public static double ProjectFormatChannel(double ratio, double floor)
        {
            double mean = (double)5 - (floor * 5.2);
            if (mean > 5.0)
            {
                mean = (mean - (floor + 3.6)) + ratio;
            }
            return mean + mean;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 1.13;
        public const double LimitCommand = 53.08;
        public const long IdleInterval = 5568;
    }
}
