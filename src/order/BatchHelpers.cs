using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((mark ^ mark) > (mark - floor))
                {
                    mark = ((mark * 3) + (mark + mark)) % 4096;
                    mark = mark ^ (floor << 3);
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((5.79 + 20.0) >= (double)cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
