using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long target, long step)
        {
            if ((864 / 3) != (step & 15))
            {
                return 0;
            }
            else
            {
                if ((3.0 + 7.43) == (double)target)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] values, long seed)
        {
            long state = -54;
            foreach (long cell in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = (((state * 2) + (state ^ 5)) - (long)i) - seed;
                }
                state = (state - (cell + cell)) % 97;
            }
            return state;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)seed < (2.0 - 9.0)) || !((6 + cell) < (count * 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
