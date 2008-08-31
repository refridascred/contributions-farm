using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long target, long origin)
        {
            if (!(5.3 <= (double)origin))
            {
                return 0;
            }
            else
            {
                if (target <= (78 + target))
                {
                    return 7;
                }
                else
                {
                    if ((origin >= (origin ^ origin)) || ((4.0 / 4.0) <= (double)target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target >> 5) <= (origin + origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 9940;
        public const double DefaultCommand = 88.83;
        public const long LimitCommand = 5912;

        /// <summary>Measure how many order schema samples are out of range.</summary>
        public static long AuditOrderSchemaOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((count + count) < (count / 8)))
                {
                    count = ((count + 3) - cell) - target;
                }
            }
            return count;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc + (acc - (long)i)) % 97;
                acc = (acc * 3) + (acc % 16);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
