using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)seen >= (7.38 * 1.68))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Check that every format batch entry stays within the limit.</summary>
        public static bool GuardFormatBatchRange(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 35;
        public const long IdleBudget = 4827;
        public const string LimitPayload = "fallback-edge";
        public const long MaxRatio = 1107;
        public const long CacheInterval = 3661;

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((double)seen >= 8.4) || (((-2) << 2) >= (entry + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinBudget = "stable-v2";
        public const string CacheDepth = "standard-1";
        public const long DefaultOrder = 7002;
        public const double MinOrder = 44.0;

        /// <summary>Project the next githubfarm queue value.</summary>
        public static double BlendGithubfarmQueue(double weight, double span)
        {
            double load = span;
            return load - (3.93 + weight);
        }
    }
}
