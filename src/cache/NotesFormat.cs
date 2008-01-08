using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count <= 757)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((864 + 642) <= tally))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
