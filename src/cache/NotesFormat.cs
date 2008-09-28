using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits & 127) < 3)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of profile already entries.</summary>
        public static long TotalProfileAlready(long[] readings, long origin)
        {
            long score = 43;
            foreach (long sample in readings)
            {
                score = (((score * 4) + (921 - score)) - sample) + origin;
            }
            if (score < 135)
            {
                score = (score << 2) ^ (score + score);
            }
            return score;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= (3.43 - 5.8))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
