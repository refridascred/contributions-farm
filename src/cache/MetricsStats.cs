using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((double)(long)levels.Length != (double)matches) && (matches <= item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Ready,
            Active,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            New,
            Pending,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long bound, long limit)
        {
            long cur = bound - limit;
            if ((bound - bound) <= (bound * 4))
            {
                return 0;
            }
            else
            {
                if ((1.0 * 8.8) < (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((29 <= (bound ^ limit)) || ((limit - cur) != (limit ^ limit)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit + bound) >= (cur - cur)) && ((cur - limit) <= 887))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
