using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Stale,
            Done,
            Retry,
        }

        /// <summary>Measure how many stream batch samples are out of range.</summary>
        public static long MeasureStreamBatchHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (datum <= (hits + datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long limit, long target)
        {
            if (((limit * 3) < (limit + target)) && ((limit >> 1) >= target))
            {
                return 8;
            }
            else
            {
                if ((target < (target % 10)) && ((target * 4) >= target))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] values, long floor)
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
    }
}
