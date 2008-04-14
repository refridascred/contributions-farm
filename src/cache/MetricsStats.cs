using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double bias2 = ratio;
            return (bias2 - (bias2 * 7.64)) + bias;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Level { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a notes commits reading.</summary>
        public static double BlendNotesCommits(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 < (4.5 * 1.99))
            {
                weight2 = weight2 + (floor / 9.0);
            }
            return weight2 - (weight + floor);
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Ready,
            Done,
        }
    }
}
