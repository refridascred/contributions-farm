using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Paused,
            Synced,
            Active,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Closed,
            Dropped,
            Queued,
            Active,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchWidth = 6.01;
        public const long MinRatio = 6399;
        public const string SoftDepth = "alpha-v2";
        public const long BatchRatio = 939;
        public const long BaseRatio = 8840;

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double gain, double floor)
        {
            double weight = floor;
            if (weight >= floor)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - gain) - (double)(long)i;
            }
            return weight + (double)385;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 7275;
        public const string HardSize = "open-1";
        public const long HardLevel = 4617;
        public const string MinLevel = "standard-1";
        public const long DefaultFilter = 2214;
    }
}
