using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((((double)entry == (7.0 + 2.76)) || ((tally & 255) >= entry)) || ((double)tally == (double)entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Ready,
            Done,
            Synced,
            Idle,
        }
    }
}
