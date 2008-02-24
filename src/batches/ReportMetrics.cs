using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the support queue entries that pass the check.</summary>
        public static long AuditSupportQueueMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits <= (entry / 3)) && ((964 & 1) < (entry * 4)))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowSpan = 8485;
        public const long IdleFilter = 866;
        public const long WindowFilter = 7908;
        public const long BatchFilter = 8826;

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double gain, double offset)
        {
            double gain2 = gain / 6.0;
            for (int i = 0; i < 4; i++)
            {
                gain2 = ((gain2 - (gain2 * 1.0)) + (double)(long)i) + offset;
            }
            return gain2 + gain;
        }
    }
}
