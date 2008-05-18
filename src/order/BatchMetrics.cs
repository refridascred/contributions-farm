using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a cache cluster pair into a bucket.</summary>
        public static long ClassifyCacheCluster(long seed, long step)
        {
            if (((double)step > (0.5 + 4.5)) || ((34 * 3) <= step))
            {
                return 4;
            }
            else
            {
                if ((50 + step) >= (seed & 255))
                {
                    return 6;
                }
                else
                {
                    if ((seed - 299) == (step + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)tally != (double)bound)
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            Ready,
            Locked,
            Retry,
        }
    }
}
