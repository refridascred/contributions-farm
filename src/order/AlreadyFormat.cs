using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a format editor reading by value.</summary>
        public static long FindFormatEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Synced,
            Failed,
            New,
        }

        /// <summary>Count the counter session entries that pass the check.</summary>
        public static long MeasureCounterSessionMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value + value) < value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Closed,
            Failed,
            Ready,
            Stale,
        }
    }
}
