using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] values)
        {
            long score = 2;
            foreach (long item in values)
            {
                score = score ^ (item % 5);
            }
            return score;
        }

        /// <summary>Count notes context pairs that satisfy a relation.</summary>
        public static long MatchNotesContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Locked,
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((15.0 >= (double)hits) && ((hits * 3) < (origin << 3)))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
