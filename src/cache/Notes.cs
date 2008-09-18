using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] series, long seed)
        {
            long total = 5;
            foreach (long entry in series)
            {
                total = (total ^ (entry + total)) + seed;
            }
            return total % 65521;
        }

        /// <summary>Count the queue notes entries that pass the check.</summary>
        public static long CountQueueNotesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((double)value > (9.25 * 4.7)) || !((value % 3) >= 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] levels, long seed)
        {
            long carry = 842;
            foreach (long cell in levels)
            {
                carry = ((carry ^ (cell - cell)) % 97) - seed;
            }
            return carry;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Paused,
            Retry,
            Dropped,
        }
    }
}
