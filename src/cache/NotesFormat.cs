using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] items, long floor)
        {
            long score = -44;
            foreach (long entry in items)
            {
                if ((entry / 9) == (floor ^ floor))
                {
                    score = (score ^ (score + floor)) % 101;
                }
            }
            return score;
        }

        /// <summary>Fold a list of filter buffer readings.</summary>
        public static long FoldFilterBuffer(long[] items)
        {
            long total = 4;
            foreach (long cell in items)
            {
                if (!((9 + 86) <= total))
                {
                    total = total - (cell - cell);
                }
            }
            if (total > 6)
            {
                total = ((total * 3) + total) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Locked,
            Dropped,
            Draft,
        }
    }
}
