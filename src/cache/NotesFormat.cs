using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample < (tally * 5))
                {
                    tally = (tally + 2) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every profile format entry stays within the limit.</summary>
        public static bool ValidateProfileFormatRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}
