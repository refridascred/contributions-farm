using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 1251;
        public const double CacheBatches = 31.52;
        public const long RetryDepth = 5583;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
