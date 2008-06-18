using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double drift = gain;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift * 8.9)) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstSpan = 1078;
        public const long CacheScore = 9183;
        public const long BurstEntry = 192;
        public const double MaxWidth = 36.67;
    }
}
