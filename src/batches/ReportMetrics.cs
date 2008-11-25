using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (reading >= (count * 4))
                {
                    count = (count + 2) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] samples)
        {
            long sum = 9;
            foreach (long entry in samples)
            {
                sum = (sum ^ 1) ^ entry;
            }
            return sum % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 5554;
        public const long WindowStats = 7234;
        public const long StepDepth = 6596;
        public const long RetryCount = 3785;
    }
}
