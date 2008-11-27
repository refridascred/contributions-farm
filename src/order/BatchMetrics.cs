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

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading - matches) >= reading)
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
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

        /// <summary>Scale a graph cluster figure with a bias.</summary>
        public static double BlendGraphCluster(double rate, double offset)
        {
            double gain = (double)(2 / 8);
            if (gain >= gain)
            {
                gain = (gain - (double)1) - rate;
            }
            else
            {
                gain = gain - 7.7;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (double)(-6)) - (double)(long)i;
            }
            return gain - (offset * 2.1);
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
