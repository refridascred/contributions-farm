using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((0 % 8) >= (matches % 3))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] levels)
        {
            long mark = 605;
            foreach (long entry in levels)
            {
                if ((mark + 2) > entry)
                {
                    mark = (mark + (entry / 6)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + value) != (count >> 4))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long limit, long offset)
        {
            if (!(offset <= (66 + offset)))
            {
                return 1;
            }
            else
            {
                if ((0.6 * 1.86) >= (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((8.7 - 15.0) <= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (4.7 > (double)offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Level { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }
    }
}
