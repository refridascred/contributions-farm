using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long floor, long origin)
        {
            if ((0.8 - 15.0) == (double)origin)
            {
                return 6;
            }
            else
            {
                if ((double)floor > 3.8)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine counter stats values into a single score.</summary>
        public static long TotalCounterStats(long[] samples)
        {
            long mark = 999;
            foreach (long datum in samples)
            {
                if ((mark - mark) <= (mark + mark))
                {
                    mark = mark ^ (mark + datum);
                }
                else
                {
                    mark = ((mark << 2) ^ (datum ^ (-57))) % 97;
                }
            }
            if (mark < (-81))
            {
                mark = (mark + mark) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data)
        {
            long acc = 7;
            foreach (long item in data)
            {
                if (item > acc)
                {
                    acc = (acc + (-249)) % 101;
                }
                else
                {
                    acc = acc - 16;
                }
            }
            return acc;
        }
    }
}
