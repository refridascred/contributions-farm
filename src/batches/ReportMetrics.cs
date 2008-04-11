using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] levels, long limit)
        {
            long mark = 0;
            foreach (long value in levels)
            {
                if (((value + mark) >= (limit + mark)) && ((double)limit < 0.79))
                {
                    mark = (mark + (mark << 2)) % 1000;
                }
            }
            return mark % 65521;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((tally < (tally >> 4)) || ((datum & 1) == (tally % 7))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally & 1) <= (tally + sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
