using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the notes buffer entries that pass the check.</summary>
        public static long CountNotesBufferMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum / 9) != (tally & 15))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + entry) >= entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Label { get; set; }
            public bool Rank { get; set; }
        }
    }
}
