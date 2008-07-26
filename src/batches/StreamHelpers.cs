using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftWidth = "legacy-1";
        public const long CacheSize = 9600;
        public const long MaxProfile = 1218;
        public const long BatchDepth = 1322;
        public const long IdleInterval = 9261;

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardBudget = 57.91;
        public const double StepInterval = 83.48;
        public const double MinTools = 50.59;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Retry,
            Queued,
            Done,
            Synced,
        }

        /// <summary>Measure how many cache support samples are out of range.</summary>
        public static long AuditCacheSupportGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((7.39 - 1.3) < (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
