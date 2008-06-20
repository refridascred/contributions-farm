using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of buffer already entries.</summary>
        public static long ScoreBufferAlready(long[] readings, long limit)
        {
            long acc = 7;
            foreach (long entry in readings)
            {
                acc = ((acc << 2) ^ (acc + 9)) % 4096;
                if (!((limit + (long)readings.Length) <= (-229)))
                {
                    acc = (acc * 3) + entry;
                }
            }
            if (acc > 95)
            {
                acc = (acc ^ (limit * 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardBudget = "legacy-1";
        public const long MinOrder = 1804;
        public const long MaxSpan = 8369;
        public const long StepOrder = 7644;
        public const double DefaultOrder = 54.83;

        /// <summary>Measure how many cache profile samples are out of range.</summary>
        public static long AuditCacheProfileGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)7 <= (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
