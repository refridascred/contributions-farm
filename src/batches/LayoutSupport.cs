using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank metric entry input into a small class.</summary>
        public static long RankMetricEntry(long step, long target)
        {
            if ((double)step > (3.05 / 7.0))
            {
                return 3;
            }
            else
            {
                if ((step * 4) < ((-5) >> 1))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long offset, long bound)
        {
            if ((13.0 - 9.63) != (double)offset)
            {
                return 6;
            }
            else
            {
                if ((bound + bound) >= (offset % 10))
                {
                    return 0;
                }
                else
                {
                    if ((offset + (-99)) >= (offset & 127))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Active,
            Queued,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 249;
        public const string CacheToken = "stable";
        public const long CacheLevel = 634;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
