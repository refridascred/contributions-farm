using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (target >= (matches + 1))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardWidth = 5.94;
        public const string StepSpan = "open-edge";
        public const long StepCount = 2449;
        public const double BurstSize = 74.58;
        public const string BatchReport = "cached-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultSize = 8701;
        public const long BatchQueue = 1149;
        public const double CacheQueue = 9.45;
        public const long DefaultScore = 9691;
    }
}
