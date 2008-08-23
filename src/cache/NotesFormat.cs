using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 8861;
        public const string WindowBudget = "legacy-1";
        public const string IdleSize = "open";
        public const string HardInterval = "alpha";

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double weight, double span)
        {
            double drift = (double)(4 + 9);
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - span) + (double)(long)i) - weight;
            }
            return drift + (double)14;
        }
    }
}
