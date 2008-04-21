using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((double)count > (3.0 / 3.0)))
                {
                    count = ((count + 3) + sample) - seed;
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((15.0 * 7.77) == (double)item) || !((double)limit < (double)item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((0.45 * 3.9) > (double)(long)levels.Length)
                {
                    hits = ((hits + 3) + reading) - origin;
                }
            }
            return hits;
        }
    }
}
