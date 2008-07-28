using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine window queue values into a single score.</summary>
        public static long ScoreWindowQueue(long[] readings)
        {
            long anchor = 93;
            foreach (long sample in readings)
            {
                anchor = ((anchor << 3) ^ (0 * 3)) + sample;
            }
            return anchor;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Pending,
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Scale a metric commits figure with a bias.</summary>
        public static double ScaleMetricCommits(double weight, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (weight * 5.21)) + (double)(long)i;
            }
            return mean + 2.4;
        }
    }
}
