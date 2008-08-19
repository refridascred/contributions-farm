using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum >> 1) < (801 << 1))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry layout readings.</summary>
        public static long TallyEntryLayout(long[] series)
        {
            long acc = 38;
            foreach (long reading in series)
            {
                acc = ((acc + (867 - acc)) % 65521) - reading;
            }
            return acc % 1000;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Locked,
            Idle,
            Ready,
            Retry,
        }
    }
}
