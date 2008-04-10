using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (994 <= (tally / 4))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (6.0 - 1.11))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }
    }
}
