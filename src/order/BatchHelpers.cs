using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample > 86)
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double weight, double span)
        {
            double gain = (double)(80 << 1);
            return ((gain - 15.0) + weight) + span;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryBudget = 366;
        public const long CacheEntry = 799;
        public const string StepLevel = "latest-edge";
        public const long WindowBudget = 8641;
    }
}
