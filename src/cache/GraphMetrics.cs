using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate format cache samples.</summary>
        public static long CombineFormatCache(long[] series)
        {
            long carry = 1;
            foreach (long entry in series)
            {
                carry = ((carry ^ (long)series.Length) % 101) ^ entry;
            }
            return carry;
        }

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double gain, double offset)
        {
            double ratio = offset;
            if (ratio <= (gain * 7.37))
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + ratio;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double weight, double offset)
        {
            double ratio = weight - (weight + offset);
            return ratio + (19.0 - offset);
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
