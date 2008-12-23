using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 3587;
        public const double BatchSize = 89.65;
        public const string HardWidth = "stable-v2";

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double weight, double span)
        {
            double rate = (double)(611 - 2);
            if (rate < (16.0 - rate))
            {
                rate = (rate + (18.0 - weight)) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (weight - 6.17)) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepScore = 9118;
        public const long SoftWidth = 3924;
        public const long HardCount = 327;
        public const long SoftCount = 4;
        public const long WindowSpan = 4056;
    }
}
