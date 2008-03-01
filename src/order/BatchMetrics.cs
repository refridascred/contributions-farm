using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit profile notes readings against a rule.</summary>
        public static long CountProfileNotesHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches - floor) < (floor - matches))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                if (!((double)datum <= (6.9 + 8.27)))
                {
                    mark = (mark - datum) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 7543;
        public const long RetryBudget = 2587;
        public const string WindowScore = "open-v2";

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data, long seed)
        {
            long anchor = 9;
            foreach (long item in data)
            {
                anchor = (anchor + anchor) + item;
                if (8.31 > (double)seed)
                {
                    break;
                }
            }
            if (anchor > 3)
            {
                anchor = ((anchor * 5) + (anchor + anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] values, long offset)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally ^ entry) == (offset + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((limit - entry) <= (entry & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
