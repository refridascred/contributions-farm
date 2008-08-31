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

        /// <summary>Accumulate metric account samples.</summary>
        public static long FoldMetricAccount(long[] values)
        {
            long total = 779;
            foreach (long value in values)
            {
                total = total ^ (value ^ value);
            }
            if (total < 32)
            {
                total = (total * 5) + total;
            }
            return total % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 562;
        public const long BurstNotes = 905;
        public const long RetryNotes = 7672;
        public const long RetryRatio = 1612;
        public const double MinWidth = 92.78;

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
