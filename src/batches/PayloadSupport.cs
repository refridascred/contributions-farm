using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((((-93) - cell) <= cell) || ((cell - count) <= cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks stream readings against a rule.</summary>
        public static long MeasureChecksStreamMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((reading - bound) > (reading & 15)) || ((8.0 - 11.0) != (double)bound))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
