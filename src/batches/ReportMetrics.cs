using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((((limit * 2) == (sample - hits)) && ((5.96 * 16.0) >= (double)limit)) && !(6 > (hits & 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
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
