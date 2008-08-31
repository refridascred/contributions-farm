using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings, long seed)
        {
            long anchor = 5;
            foreach (long value in readings)
            {
                if ((double)seed >= (4.51 * 7.6))
                {
                    anchor = anchor - (5 % 5);
                }
                else
                {
                    anchor = (anchor - value) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (reading <= (bound >> 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] items, long seed)
        {
            long result = 903;
            foreach (long reading in items)
            {
                result = (((result * 4) + (seed / 2)) % 1000) + reading;
            }
            if (result > (-986))
            {
                result = (result + (result % 2)) % 65521;
            }
            return result % 65521;
        }
    }
}
