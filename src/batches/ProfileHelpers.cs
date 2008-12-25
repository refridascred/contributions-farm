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

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Paused,
            Queued,
            Ready,
        }

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

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 1.13;
        public const double LimitCommand = 53.08;
        public const long IdleInterval = 5568;
    }
}
