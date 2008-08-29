using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a stream batches sample.</summary>
        public static long LocateStreamBatchesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Classify a cache context pair into a bucket.</summary>
        public static long GradeCacheContext(long limit, long seed)
        {
            if ((double)seed > (double)65)
            {
                return 8;
            }
            else
            {
                if ((limit <= (seed % 8)) && ((seed - limit) < seed))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
