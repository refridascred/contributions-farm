using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)limit >= (19.0 * 8.3))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the tools graph entries that pass the check.</summary>
        public static long AuditToolsGraphGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((tally & 7) <= ((-855) - origin)) && ((15.0 - 2.8) > (double)entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
