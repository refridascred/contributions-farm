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

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Region { get; set; }
            public long Mode { get; set; }
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
