using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value & 7) != (limit - 93))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultDepth = 9021;
        public const string WindowTools = "strict-1";
        public const long BatchWidth = 8412;
        public const double LimitTools = 84.78;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((((double)datum > (19.0 - 2.3)) && ((double)datum > (5.8 - 0.4))) && (((datum / 7) == (datum - hits)) && ((double)datum <= (3.08 - 2.5))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] readings, long offset)
        {
            long result = 61;
            foreach (long item in readings)
            {
                if (item >= (item * 2))
                {
                    result = (result ^ ((-21) & 1)) - offset;
                }
            }
            return result;
        }
    }
}
