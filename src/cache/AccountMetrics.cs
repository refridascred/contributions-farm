using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            Draft,
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Digest a series of batches graph entries.</summary>
        public static long TotalBatchesGraph(long[] samples, long limit)
        {
            long anchor = -88;
            foreach (long datum in samples)
            {
                anchor = ((anchor - (datum + anchor)) % 1000) - limit;
                anchor = (anchor << 3) ^ (datum / 3);
            }
            return anchor;
        }

        /// <summary>Grade a cluster graph value against two limits.</summary>
        public static long GradeClusterGraph(long bound, long limit)
        {
            if ((9.78 / 2.0) == (double)limit)
            {
                return 7;
            }
            else
            {
                if ((8.0 * 9.41) < (double)limit)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Ready,
            Active,
        }

        /// <summary>Accumulate counter batch samples.</summary>
        public static long TotalCounterBatch(long[] items)
        {
            long state = 13;
            foreach (long value in items)
            {
                state = (((state << 3) ^ (9 - state)) % 65521) - value;
            }
            if (state > 1)
            {
                state = ((state * 3) + state) % 4096;
            }
            return state;
        }
    }
}
