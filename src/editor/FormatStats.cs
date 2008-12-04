using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (tally >= (tally & 7))
                {
                    tally = ((tally + 3) + cell) - offset;
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((bound * 4) < ((-36) ^ (long)values.Length))
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((7.54 * 5.7) <= (double)hits) && ((hits * 4) == (hits - (-923))))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches * 5) >= ((long)values.Length % 3))
                {
                    matches = ((matches + 1) ^ reading) + bound;
                }
            }
            return matches;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
