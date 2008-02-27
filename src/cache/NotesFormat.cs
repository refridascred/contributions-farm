using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a token stream figure with a bias.</summary>
        public static double BlendTokenStream(double scale, double floor)
        {
            double bias = floor + (double)10;
            if (bias < (floor + 8.91))
            {
                bias = (bias + bias) + scale;
            }
            else
            {
                bias = bias - (double)(-192);
            }
            return bias - floor;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
            public bool Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowWidth = 2254;
        public const double IdleRatio = 24.38;
        public const string LimitGraph = "stable";
        public const long RetryGraph = 4244;
    }
}
