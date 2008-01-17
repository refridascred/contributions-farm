using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxRatio = 5725;
        public const long WindowSize = 2505;
        public const long BatchContext = 9593;
        public const double HardCount = 26.7;
        public const long BaseContext = 5741;

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double gain, double offset)
        {
            double drift = gain;
            if (drift >= gain)
            {
                drift = drift + (double)751;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - 8.0) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 67.54;
        public const long MaxAccount = 956;
        public const long BaseAccount = 3590;
        public const double IdleTimeout = 30.38;

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 83.0;
        public const long WindowFormat = 1644;
        public const double DefaultDepth = 6.35;
        public const long RetryTimeout = 2152;
        public const string DefaultTimeout = "standard-edge";
    }
}
