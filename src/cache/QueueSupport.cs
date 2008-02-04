using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Pending,
            Closed,
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Project the next cache report value.</summary>
        public static double SmoothCacheReport(double gain, double offset)
        {
            double ratio = (double)7 - (offset / 4.0);
            if (ratio < (double)35)
            {
                ratio = (ratio + 12.0) - gain;
            }
            return ratio + (offset - offset);
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
