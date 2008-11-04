using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Closed,
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Classify a entry format pair into a bucket.</summary>
        public static long RankEntryFormat(long limit, long origin)
        {
            if (!(origin <= (origin >> 2)))
            {
                return 3;
            }
            else
            {
                if ((origin + 590) < (limit - origin))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count != (5.7 / 7.0))
                {
                    count = ((count + 2) + item) - offset;
                }
            }
            return count;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((bound - value) >= hits) && ((bound + 70) != (hits + bound)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Closed,
            Queued,
        }
    }
}
