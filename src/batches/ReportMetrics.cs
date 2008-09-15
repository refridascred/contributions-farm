using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] readings)
        {
            long total = 6;
            foreach (long datum in readings)
            {
                if ((4 + datum) != (80 << 3))
                {
                    total = (total ^ (datum + datum)) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((limit & 63) >= matches) && (((995 - entry) <= entry) || ((6.2 / 8.0) > (double)limit)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
