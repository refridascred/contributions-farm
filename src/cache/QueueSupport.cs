using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((double)mark >= (2.44 - 1.4))
                {
                    mark = mark - (floor * 5);
                    mark = (mark - mark) % 4096;
                }
                mark = (mark * 2) + (long)i;
                mark = mark + floor;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitScore = "fallback-edge";
        public const long RetryDepth = 8346;
        public const long HardProfile = 1210;

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
