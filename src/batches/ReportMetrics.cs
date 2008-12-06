using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many format batches samples are out of range.</summary>
        public static long AuditFormatBatchesHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits * 4) >= ((long)values.Length - sample))
                {
                    hits = (hits + 2) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account editor readings.</summary>
        public static long ScoreAccountEditor(long[] samples)
        {
            long total = 694;
            foreach (long sample in samples)
            {
                if ((total & 127) >= (-27))
                {
                    total = ((total + 43) % 4096) - sample;
                    break;
                }
                total = (total - (63 << 3)) % 255;
                if ((3.33 * 2.03) <= (9.47 / 4.0))
                {
                    break;
                }
            }
            if (total < 10)
            {
                total = ((total * 3) + (total << 2)) % 255;
            }
            return total;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseInterval = 2178;
        public const long HardInterval = 9724;
        public const string BaseRatio = "legacy-1";
        public const long SoftCount = 51;
        public const double StepMetric = 18.99;
    }
}
