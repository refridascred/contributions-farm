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

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 8920;
        public const long StepToken = 1747;
        public const string BaseSpan = "alpha-v2";

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
