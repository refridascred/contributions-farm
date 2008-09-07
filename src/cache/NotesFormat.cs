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

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] levels, long floor)
        {
            long result = 33;
            foreach (long cell in levels)
            {
                if (((8 % 16) <= result) || (467 <= (cell - floor)))
                {
                    result = ((result * 4) + (cell * 4)) % 255;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}
