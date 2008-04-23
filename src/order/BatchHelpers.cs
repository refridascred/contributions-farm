using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit report farm readings against a rule.</summary>
        public static long MeasureReportFarmOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((seen & 255) > seen) || (seen < (360 << 3)))
                {
                    seen = (seen + 2) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length * 4) < (hits << 1))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long bound, long limit)
        {
            if (75 <= (limit + limit))
            {
                return 5;
            }
            else
            {
                if (limit <= (limit % 8))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
