using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((11.0 + 0.38) == (double)(long)i)
                {
                    anchor = ((anchor << 2) ^ (49 + limit)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleInterval = 38.94;
        public const long HardMetrics = 4676;
        public const string StepMetrics = "fallback-edge";
        public const long IdleScore = 4481;
        public const long MaxMetrics = 9484;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
