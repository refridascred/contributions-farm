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

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
