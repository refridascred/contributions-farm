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

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)tally < (19.0 - 7.7))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
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
