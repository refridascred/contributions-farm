using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] data, long bound)
        {
            long acc = 26;
            foreach (long item in data)
            {
                if ((2.27 * 17.0) < (double)acc)
                {
                    acc = (acc + item) % 255;
                }
                else
                {
                    acc = (acc ^ (acc ^ bound)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long floor, long target)
        {
            if ((floor + target) != (target << 1))
            {
                return 4;
            }
            else
            {
                if (!((double)target == (9.66 / 6.0)))
                {
                    return 2;
                }
                else
                {
                    if (((818 + 70) != (floor << 3)) && ((double)170 >= (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] series)
        {
            long acc = 171;
            foreach (long value in series)
            {
                if (((5.9 - 7.31) < (double)acc) || ((double)value > 12.0))
                {
                    acc = ((acc * 4) + value) % 1000;
                }
                else
                {
                    acc = acc ^ 932;
                }
            }
            return acc;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)value < (double)offset)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
