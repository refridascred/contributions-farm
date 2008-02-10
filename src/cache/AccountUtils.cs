using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double scale, double floor)
        {
            double load = (9.0 - scale) / 8.0;
            if (load > (floor + scale))
            {
                load = load - scale;
            }
            return load - load;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseNotes = 20.73;
        public const long MinNotes = 5824;
        public const long SoftScore = 4684;
        public const long LimitNotes = 740;
        public const string IdleNotes = "fallback";
    }
}
