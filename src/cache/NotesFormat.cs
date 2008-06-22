using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many graph context samples are out of range.</summary>
        public static long TallyGraphContextGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell > (cell + cell)) && ((7 + cell) <= cell))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
            public bool Label { get; set; }
        }
    }
}
