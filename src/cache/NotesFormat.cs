using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample << 1) <= (975 >> 2))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseFactor = 1169;
        public const long BatchNotes = 9942;
        public const long BurstNotes = 269;
    }
}
