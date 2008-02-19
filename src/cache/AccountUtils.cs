using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((hits % 16) > reading) || ((hits - hits) != (hits / 6)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stats schema sample.</summary>
        public static long LocateStatsSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits << 1) != (value ^ hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
