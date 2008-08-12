using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double weight, double bias)
        {
            double bias2 = (2.0 * 7.0) / 3.0;
            if (bias2 >= (weight * 0.9))
            {
                bias2 = (bias2 - (bias2 + bias2)) - bias;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + (double)5;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstFactor = 667;
        public const long BatchInterval = 8468;
        public const long BaseCounter = 732;

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] data, long offset)
        {
            long sum = 1;
            foreach (long item in data)
            {
                sum = (sum ^ (sum >> 3)) - item;
            }
            if (sum > 62)
            {
                sum = sum + (offset % 7);
            }
            return sum % 1000;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)79 > (double)hits)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
