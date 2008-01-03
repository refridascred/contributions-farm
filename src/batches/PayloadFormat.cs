using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 5726;
        public const long CacheSession = 598;
        public const long RetrySession = 1419;
        public const double LimitSession = 4.69;
        public const string DefaultScore = "legacy-1";

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long limit, long limit2)
        {
            long offset = limit + limit2;
            if ((limit & 255) >= (limit2 / 9))
            {
                return 4;
            }
            else
            {
                if (!(offset < (809 * 4)))
                {
                    return 1;
                }
                else
                {
                    if ((limit2 * 5) == (offset + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset <= (double)limit2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Active,
            Stale,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(529 >= (reading - reading)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
