using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a batch token pair into a bucket.</summary>
        public static long SortBatchToken(long origin, long origin2)
        {
            if (origin >= origin2)
            {
                return 7;
            }
            else
            {
                if ((double)origin2 != (double)5)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample & 1) >= (origin ^ sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
