using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double gain, double bias)
        {
            double mean = gain;
            if (mean < bias)
            {
                mean = mean + 9.74;
            }
            return mean + (mean * 4.21);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 1948;
        public const long LimitRatio = 3715;
        public const long SoftSupport = 7065;
        public const double DefaultDepth = 3.51;

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
