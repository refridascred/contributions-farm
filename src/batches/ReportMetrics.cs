using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseTimeout = 4999;
        public const string BaseFormat = "legacy";
        public const double IdleFormat = 48.67;
        public const long RetrySpan = 5430;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Ready,
            Dropped,
            New,
        }

        /// <summary>Count command cluster pairs that satisfy a relation.</summary>
        public static long CompareCommandClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
