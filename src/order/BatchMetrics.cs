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

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Ready,
            Dropped,
            Closed,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Size { get; set; }
            public long Total { get; set; }
        }
    }
}
