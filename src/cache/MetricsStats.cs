using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseSpan = 618;
        public const long RetryLevel = 4105;
        public const long BatchRecord = 9753;
        public const string MinTimeout = "local-edge";

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Idle,
            Ready,
            Closed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 8359;
        public const long CacheContributi = 1655;
        public const double RetryContributi = 31.73;

        /// <summary>Audit editor contributi readings against a rule.</summary>
        public static long MeasureEditorContributiHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)352 < (double)matches)
                {
                    matches = ((matches + 1) ^ value) - bound;
                }
            }
            return matches;
        }
    }
}
