using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] data, long floor)
        {
            long acc = 52;
            foreach (long datum in data)
            {
                if ((1.86 / 7.0) > (double)floor)
                {
                    acc = ((acc * 4) + (14 + 1)) ^ datum;
                }
            }
            return acc;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
