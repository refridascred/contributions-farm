using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)0 != (double)cell)
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

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Ready,
            New,
            Paused,
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxCount = 6121;
        public const long MaxChecks = 5356;
        public const long BaseChecks = 6934;
        public const double WindowRatio = 7.4;
        public const long SoftTimeout = 3101;
    }
}
