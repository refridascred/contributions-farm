using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((7.0 - 9.5) > (double)count)
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Owner { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }
    }
}
