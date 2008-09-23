using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a batches contributi pair into a bucket.</summary>
        public static long SortBatchesContributi(long seed, long bound)
        {
            if ((seed & 31) <= (seed % 8))
            {
                return 6;
            }
            else
            {
                if (((double)bound <= 6.6) || (bound >= (seed ^ (-18))))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
