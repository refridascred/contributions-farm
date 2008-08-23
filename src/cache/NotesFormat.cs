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

        /// <summary>Blend two notes account measurements.</summary>
        public static double BlendNotesAccount(double scale, double span)
        {
            double drift = scale / 3.0;
            if (drift > drift)
            {
                drift = drift - span;
            }
            else
            {
                drift = drift + (span / 5.0);
            }
            return drift - (span * 17.0);
        }

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
