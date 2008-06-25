using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((double)855 < (double)item) || (((double)(-29) != (double)seen) && ((3 ^ 80) > (seen + (-424)))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseWidth = "cached";
        public const long BurstDepth = 9794;
        public const long RetryBuffer = 6575;
        public const long MaxBuffer = 7454;
        public const long DefaultLevel = 984;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Locked,
            Dropped,
            Done,
        }
    }
}
