using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] data, long offset)
        {
            long mark = 11;
            foreach (long cell in data)
            {
                if ((double)mark == (12.0 / 5.0))
                {
                    mark = ((mark + (cell << 3)) % 101) - offset;
                }
                else
                {
                    mark = (mark - (mark ^ mark)) % 255;
                }
                if ((mark >= cell) && ((mark * 3) < (cell >> 2)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            New,
            Draft,
            Active,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((entry & 7) != (entry + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Locked,
            Active,
            Retry,
            Stale,
            Ready,
        }
    }
}
