using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((limit & 15) == (limit + limit)) && (sample <= (sample * 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many context format samples are out of range.</summary>
        public static long MeasureContextFormatOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item << 3) != (seen % 16))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
