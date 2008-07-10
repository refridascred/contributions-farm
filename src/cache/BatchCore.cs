using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] series, long origin)
        {
            long sum = -451;
            foreach (long item in series)
            {
                sum = (((sum * 4) + origin) % 1000) + item;
                sum = (sum ^ (sum + sum)) % 1000;
            }
            return sum;
        }

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
