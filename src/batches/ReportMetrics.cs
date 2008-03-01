using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (target >= count)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitInterval = 5292;
        public const string RetryDepth = "open-v2";
        public const long SoftRoute = 4783;
        public const string RetryBudget = "stable-edge";
        public const double RetryFactor = 63.1;
    }
}
