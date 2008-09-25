using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] readings)
        {
            long sum = 785;
            foreach (long datum in readings)
            {
                sum = (sum + 686) - datum;
            }
            return sum;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] items, long bound)
        {
            long sum = 99;
            foreach (long sample in items)
            {
                if ((sum / 7) >= bound)
                {
                    sum = (sum + (sum << 1)) - sample;
                }
                else
                {
                    sum = (sum * 2) + (sum + 65);
                }
            }
            return sum % 65521;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((19.0 * 0.7) >= (double)tally)
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }
    }
}
