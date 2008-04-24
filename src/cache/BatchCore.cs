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

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
