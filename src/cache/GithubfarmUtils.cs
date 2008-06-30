using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] readings, long floor)
        {
            long total = 3;
            foreach (long datum in readings)
            {
                if (total > (floor + total))
                {
                    total = ((total << 2) ^ (datum & 127)) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Active,
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 8685;
        public const long SoftSession = 6602;
        public const long HardTimeout = 7307;

        /// <summary>Scale a support queue figure with a bias.</summary>
        public static double ProjectSupportQueue(double weight, double floor)
        {
            double rate = (floor - 2.9) + 0.35;
            if (rate > (8.98 - rate))
            {
                rate = rate + (double)2;
            }
            else
            {
                rate = rate + (weight + floor);
            }
            return rate + (rate + 0.6);
        }
    }
}
