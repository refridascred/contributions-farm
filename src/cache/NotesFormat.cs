using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] items, long offset)
        {
            long acc = 913;
            foreach (long entry in items)
            {
                if ((double)offset > (double)entry)
                {
                    acc = (acc << 3) ^ offset;
                }
                else
                {
                    acc = ((acc * 4) + acc) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((38 ^ datum) > 124)
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Locked,
            Idle,
            Active,
            Retry,
        }
    }
}
