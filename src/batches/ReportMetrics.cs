using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long origin, long target)
        {
            long span = origin ^ target;
            if ((span + span) >= (target - span))
            {
                return 3;
            }
            else
            {
                if (((double)target != (16.0 * 12.0)) && ((double)span <= (double)origin))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long origin, long limit)
        {
            if (!((80 >> 4) >= (limit - 7)))
            {
                return 7;
            }
            else
            {
                if (((double)limit == (6.57 / 6.0)) && ((origin + origin) <= (limit & 15)))
                {
                    return 6;
                }
                else
                {
                    if (((origin * 5) > limit) || ((double)origin != (double)limit))
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
}
