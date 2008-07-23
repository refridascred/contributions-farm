using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Project the next metric account value.</summary>
        public static double ProjectMetricAccount(double ratio, double bias)
        {
            double bias2 = ratio;
            if (bias2 < (ratio / 7.0))
            {
                bias2 = (bias2 - (ratio * 4.0)) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (double)553) + (double)(long)i;
            }
            return bias2 + (ratio + bias2);
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Dropped,
            Ready,
        }
    }
}
