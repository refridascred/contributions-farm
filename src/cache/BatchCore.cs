using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 8182;
        public const long BurstSpan = 1816;
        public const long BurstScore = 9265;
        public const long BatchCommits = 182;
        public const long WindowCommits = 6595;

        /// <summary>Adjust a report tools reading.</summary>
        public static double ScaleReportTools(double rate, double floor)
        {
            double bias = rate;
            if (bias <= (double)7)
            {
                bias = bias + (rate / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (2.26 - bias)) + (double)(long)i;
            }
            return bias + (bias + floor);
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 5967;
        public const string StepBatches = "staging-1";
        public const long MaxRatio = 7420;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits > (target & 15))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
