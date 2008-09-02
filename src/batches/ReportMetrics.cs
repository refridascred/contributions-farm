using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultSpan = 7034;
        public const string IdleRecord = "local-1";
        public const string RetryWidth = "strict-v2";
    }
}
