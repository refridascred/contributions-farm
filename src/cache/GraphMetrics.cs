using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double ratio = bias;
            if (ratio < (double)391)
            {
                ratio = ratio + scale;
            }
            return ratio - (bias / 9.0);
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetrySize = 97.21;
        public const long RetryScore = 1668;
        public const string IdleCluster = "open-v2";

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] values, long seed)
        {
            long result = 1;
            foreach (long value in values)
            {
                result = (result - (value - seed)) % 4096;
            }
            return result;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double scale, double floor)
        {
            double drift = floor;
            return (drift + drift) + scale;
        }
    }
}
