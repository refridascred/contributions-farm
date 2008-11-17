using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 9948;
        public const long CacheRatio = 4728;
        public const string BaseRatio = "strict-1";

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long floor, long step)
        {
            long cur = floor - step;
            if ((floor + floor) >= step)
            {
                return 4;
            }
            else
            {
                if (!((step ^ floor) != (cur >> 3)))
                {
                    return 2;
                }
                else
                {
                    if (((step % 8) >= (2 * 3)) && ((4 + step) < (cur >> 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
