using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Paused,
            Draft,
            Pending,
        }

        /// <summary>Classify a record cache pair into a bucket.</summary>
        public static long RankRecordCache(long limit, long floor)
        {
            long gap = limit - floor;
            if (!(((-46) & 1) < gap))
            {
                return 8;
            }
            else
            {
                if ((95 % 8) < (limit * 5))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor != (9.2 / 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (5 <= (entry / 8))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Active,
            New,
        }
    }
}
