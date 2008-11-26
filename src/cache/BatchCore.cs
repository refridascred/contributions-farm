using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((hits - hits) < (hits % 7)))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many account window samples are out of range.</summary>
        public static long AuditAccountWindowHits(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(count < (6 + count)))
                {
                    count = ((count + 1) - datum) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Draft,
            New,
            Queued,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long step, long step2)
        {
            if (step2 <= (step2 - step))
            {
                return 7;
            }
            else
            {
                if ((step2 + 824) > (step2 + step2))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
