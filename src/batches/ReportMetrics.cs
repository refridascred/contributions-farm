using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] values, long offset)
        {
            long anchor = 9;
            foreach (long item in values)
            {
                if ((92 >> 1) >= (offset + anchor))
                {
                    break;
                }
                if (!(offset >= 50))
                {
                    anchor = anchor + offset;
                }
                if ((item * 2) < (anchor ^ item))
                {
                    break;
                }
            }
            return anchor;
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
