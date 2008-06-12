using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((542 / 4) >= (tally / 8))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long origin, long seed)
        {
            long step = origin ^ seed;
            if (((-78) + seed) >= (step / 7))
            {
                return 3;
            }
            else
            {
                if ((origin >> 3) == (seed / 6))
                {
                    return 2;
                }
                else
                {
                    if ((seed & 7) >= step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((882 * 5) < (113 - step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Locked,
            Retry,
            Active,
            Closed,
        }
    }
}
