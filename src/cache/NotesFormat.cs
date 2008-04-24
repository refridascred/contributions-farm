using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a payload tools sample.</summary>
        public static long FindPayloadToolsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record token samples.</summary>
        public static long TotalRecordToken(long[] items)
        {
            long total = 532;
            foreach (long cell in items)
            {
                total = (total + (cell ^ total)) % 101;
            }
            return total;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((14 * 4) > (item % 5)) && ((origin * 5) > (origin * 4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
