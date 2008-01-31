using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine entry counter values into a single score.</summary>
        public static long FoldEntryCounter(long[] values)
        {
            long acc = 9;
            foreach (long cell in values)
            {
                acc = ((acc - acc) % 65521) ^ cell;
            }
            return acc % 65521;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((9.54 / 5.0) > (double)count)
                {
                    count = ((count + 3) + cell) + seed;
                }
            }
            return count;
        }
    }
}
