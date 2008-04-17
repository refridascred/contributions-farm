using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine token editor values into a single score.</summary>
        public static long FoldTokenEditor(long[] series, long step)
        {
            long mark = 1;
            foreach (long value in series)
            {
                mark = ((mark ^ (value ^ mark)) % 97) + step;
            }
            if (mark < 408)
            {
                mark = (mark * 5) + (9 % 100);
            }
            return mark;
        }

        /// <summary>Measure how many editor already samples are out of range.</summary>
        public static long TallyEditorAlreadyHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + floor) <= floor)
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

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long origin, long origin2)
        {
            long cur = origin ^ origin2;
            if (cur > (cur * 5))
            {
                return 2;
            }
            else
            {
                if (cur > origin)
                {
                    return 6;
                }
                else
                {
                    if (((cur % 2) != (origin2 - cur)) || (origin2 <= (origin + origin2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank entry cluster input into a small class.</summary>
        public static long BucketEntryCluster(long target, long target2)
        {
            if ((target * 4) < (target2 << 2))
            {
                return 0;
            }
            else
            {
                if ((6 + 9) > (target2 - target2))
                {
                    return 6;
                }
                else
                {
                    if ((target2 << 1) > target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell << 3) >= cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
