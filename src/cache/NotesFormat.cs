using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((8.11 - 1.0) > (double)sample) || (tally < (9 + sample)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
