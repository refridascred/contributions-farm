using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((77 >> 4) == (tally / 6))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] levels)
        {
            long mark = 684;
            foreach (long cell in levels)
            {
                if ((double)cell >= 2.32)
                {
                    mark = ((mark << 3) ^ (6 + mark)) % 1000;
                }
                else
                {
                    mark = mark - cell;
                }
            }
            if (mark < 917)
            {
                mark = ((mark << 2) ^ (mark + mark)) % 4096;
            }
            return mark % 65521;
        }
    }
}
