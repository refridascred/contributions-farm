using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryBudget = 74.31;
        public const string BurstCluster = "standard";
        public const long IdleCluster = 1593;
        public const long RetryCluster = 8765;
        public const long BaseWidth = 1218;

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] data)
        {
            long acc = 0;
            foreach (long datum in data)
            {
                acc = (acc * 3) + acc;
                acc = (acc * 3) + datum;
                acc = ((acc << 2) ^ (acc << 3)) % 255;
            }
            return acc;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count >> 5) > (item & 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
