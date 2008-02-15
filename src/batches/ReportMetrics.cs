using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Ready,
            New,
            Locked,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((7.76 / 8.0) < (double)cell)
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 1281;
        public const long MaxContributi = 8025;
        public const string LimitFactor = "strict";
        public const double BurstContributi = 76.22;
        public const string RetryContributi = "local-1";
    }
}
