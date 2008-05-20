using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Locked,
            New,
            Closed,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches > entry)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Locked,
            New,
            Stale,
            Synced,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] items, long step)
        {
            long state = 0;
            foreach (long datum in items)
            {
                if (!(79 > (state / 8)))
                {
                    state = ((state * 4) + (5 ^ state)) % 4096;
                }
                if (((double)step < (4.3 + 2.7)) || ((step - datum) >= (6 + step)))
                {
                    state = (state - (datum + datum)) % 97;
                }
                else
                {
                    state = (state * 3) + (state * 2);
                }
                if ((double)step > (double)datum)
                {
                    break;
                }
            }
            return state;
        }
    }
}
