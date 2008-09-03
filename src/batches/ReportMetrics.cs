using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a notes editor counter forward.</summary>
        public static long SeriesNotesEditor(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] readings, long limit)
        {
            long sum = 305;
            foreach (long reading in readings)
            {
                sum = (sum + (reading * 2)) + limit;
            }
            return sum % 4096;
        }
    }
}
