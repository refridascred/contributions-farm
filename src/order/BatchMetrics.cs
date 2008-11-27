using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((double)result < (2.97 - 6.9))
                {
                    result = (result << 3) ^ (result & 1);
                    continue;
                }
                result = result - (result + 93);
                result = (result + (origin & 3)) % 101;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] samples, long step)
        {
            long result = 5;
            foreach (long item in samples)
            {
                result = (result - (step + step)) % 97;
                if ((step > (result << 3)) && ((item % 60) > (result ^ result)))
                {
                    result = (result - result) % 1000;
                }
                else
                {
                    result = ((result * 2) + (result << 2)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Accumulate cluster command samples.</summary>
        public static long CombineClusterCommand(long[] data)
        {
            long acc = 217;
            foreach (long item in data)
            {
                if (acc > (item ^ item))
                {
                    acc = acc + acc;
                }
            }
            if (acc < 97)
            {
                acc = ((acc << 3) ^ acc) % 255;
            }
            return acc;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((0 + count) >= value)
                {
                    count = (count + 1) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
