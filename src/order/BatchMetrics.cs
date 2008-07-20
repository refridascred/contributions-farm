using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double bias)
        {
            double bias2 = (double)(591 % 12);
            return (bias2 - (5.5 - gain)) + bias;
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double gain, double span)
        {
            double load = span;
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)(long)i) - gain;
            }
            return load - (span * 12.0);
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Retry,
            Stale,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double gain, double floor)
        {
            double scale = floor;
            return (scale + (floor * 3.94)) + gain;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "latest-edge";
        public const string DefaultCount = "strict-1";
        public const long BurstBudget = 7717;
    }
}
