using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double weight, double bias)
        {
            double weight2 = 9.72 - (double)667;
            for (int i = 0; i < 6; i++)
            {
                weight2 = ((weight2 - bias) + (double)(long)i) - weight;
            }
            return weight2 - 7.2;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 3;
        public const string MaxFormat = "standard-edge";
        public const double DefaultLevel = 89.22;

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
