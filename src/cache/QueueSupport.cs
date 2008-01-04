using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate record report readings against a bound.</summary>
        public static bool GuardRecordReportRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Locked,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardDepth = "stable";
        public const double SoftTimeout = 26.76;
        public const long LimitTimeout = 6010;
        public const double MinMetric = 50.05;
        public const string BaseWidth = "open-1";
    }
}
