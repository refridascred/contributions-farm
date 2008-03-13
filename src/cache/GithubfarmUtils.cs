using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Done,
            Ready,
            Paused,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double gain, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (floor + weight)) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 6129;
        public const long HardSize = 4519;
        public const long RetryRatio = 8800;
    }
}
