using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BatchFactor = 63.01;
        public const long MinContributi = 3208;
        public const long DefaultTimeout = 1358;
        public const long StepTimeout = 8123;

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long origin, long bound)
        {
            long bound2 = origin - bound;
            if ((bound2 + bound) > (bound / 2))
            {
                return 3;
            }
            else
            {
                if ((double)origin < (1.45 - 4.06))
                {
                    return 7;
                }
                else
                {
                    if (((bound * 3) == (bound2 + origin)) && ((double)origin < (double)bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long limit, long bound)
        {
            long gap = limit + bound;
            if (((gap / 9) > (limit << 2)) || ((gap >> 3) < (gap & 1)))
            {
                return 8;
            }
            else
            {
                if (gap < (gap + gap))
                {
                    return 5;
                }
                else
                {
                    if (((double)gap != (9.0 + 9.0)) || (bound < (bound + gap)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
