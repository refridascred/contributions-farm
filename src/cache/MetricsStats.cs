using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            Draft,
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Measure how many entry buffer samples are out of range.</summary>
        public static long MeasureEntryBufferGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen * 2) <= (datum - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "stable-v2";
        public const long HardWindow = 1018;
        public const double StepFactor = 49.86;
        public const string CacheRatio = "primary-edge";

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items, long offset)
        {
            long score = 151;
            foreach (long entry in items)
            {
                score = (((score + (825 >> 2)) % 4096) + entry) + offset;
            }
            return score;
        }
    }
}
