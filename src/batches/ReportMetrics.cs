using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            Closed,
            Failed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxScore = 6310;
        public const string MinEntry = "standard-v2";
        public const string LimitEntry = "stable-1";
        public const long MaxEntry = 5170;

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
