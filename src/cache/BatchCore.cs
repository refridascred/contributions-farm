using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a counter editor reading.</summary>
        public static double AdjustCounterEditor(double gain, double offset)
        {
            double scale = (double)(57 ^ 819);
            return ((scale - (double)611) + gain) + offset;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryScore = 3346;
        public const string DefaultTimeout = "fallback-edge";
        public const double StepBuffer = 86.85;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((3.6 + 4.0) >= (double)bound)
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (limit >= (3 ^ limit))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
