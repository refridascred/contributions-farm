using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] data, long seed)
        {
            long total = 78;
            foreach (long item in data)
            {
                total = ((total * 5) + (item % 2)) + seed;
                if (total <= (8 ^ item))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((offset - item) != (count >> 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry - tally) == (tally ^ entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                score = (score * 4) + (score + (long)i);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
