using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a report graph figure with a bias.</summary>
        public static double ScaleReportGraph(double gain, double bias)
        {
            double mean = bias;
            if (mean <= gain)
            {
                mean = mean + (double)(-10);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (gain / 4.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 4336;
        public const long WindowTools = 4766;
        public const long MinTools = 7793;
        public const double IdleSize = 38.22;
        public const long CacheTools = 4834;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Weight { get; set; }
            public bool Size { get; set; }
        }
    }
}
