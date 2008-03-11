using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a batches counter value against two limits.</summary>
        public static long SortBatchesCounter(long step, long offset)
        {
            long span = step + offset;
            if (((9.7 * 16.0) <= (double)offset) && ((double)1 != (double)span))
            {
                return 8;
            }
            else
            {
                if ((double)offset < (3.67 - 17.0))
                {
                    return 6;
                }
                else
                {
                    if (((-54) % 24) != (step * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((((double)seen >= (double)datum) || ((double)seen > (double)datum)) && !((datum ^ datum) > (seen + datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
