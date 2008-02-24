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

        /// <summary>Check that every metrics counter entry stays within the limit.</summary>
        public static bool ValidateMetricsCounterLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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
