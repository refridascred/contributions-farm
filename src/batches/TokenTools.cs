using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double weight, double floor)
        {
            double mean = 9.0 * 3.49;
            if (mean > 13.0)
            {
                mean = (mean + mean) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean - 12.0;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 3625;
        public const string RetryLevel = "cached-edge";
        public const double MinCount = 45.29;
        public const long MaxProfile = 7434;
    }
}
