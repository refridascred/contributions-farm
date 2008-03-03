using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long seed, long target)
        {
            long delta = seed - target;
            if ((13.0 * 4.2) <= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((double)delta <= (7.6 + 3.87))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
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
