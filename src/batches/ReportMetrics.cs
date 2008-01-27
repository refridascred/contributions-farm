using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count command support pairs that satisfy a relation.</summary>
        public static long OverlapCommandSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many report channel samples are out of range.</summary>
        public static long AuditReportChannelHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((0.3 * 5.36) == (double)item) || (((item % 100) <= (hits + 1)) && ((hits << 1) >= (limit * 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long origin, long seed)
        {
            if ((origin + origin) < seed)
            {
                return 7;
            }
            else
            {
                if (!((double)origin >= (0.43 + 3.78)))
                {
                    return 5;
                }
                else
                {
                    if ((seed * 2) == (seed << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((5.94 - 5.46) == (double)origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
