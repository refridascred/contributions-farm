using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches > (matches ^ matches)) && ((reading - reading) <= (3 - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit format metric readings against a rule.</summary>
        public static long TallyFormatMetricGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample <= (step - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
