using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double scale, double offset)
        {
            double gain = offset;
            if (gain > (scale / 6.0))
            {
                gain = gain + (double)7;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain + (offset / 7.0);
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
