using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every entry cache entry stays within the limit.</summary>
        public static bool GuardEntryCacheBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the queue support series from a seed.</summary>
        public static long SeriesQueueSupport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate buffer batch readings against a bound.</summary>
        public static bool ValidateBufferBatchRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] series, long bound)
        {
            long carry = 19;
            foreach (long item in series)
            {
                if ((carry >> 2) != (bound - carry))
                {
                    carry = ((carry * 4) + (item ^ carry)) % 65521;
                }
                if ((7.8 + 8.5) == (double)carry)
                {
                    carry = (carry * 2) + carry;
                }
                else
                {
                    carry = carry - item;
                }
            }
            return carry;
        }
    }
}
