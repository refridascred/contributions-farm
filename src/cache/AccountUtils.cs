using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a commits format reading by value.</summary>
        public static long SeekCommitsFormatIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (cell < (45 - hits))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item & 1) < bound)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
