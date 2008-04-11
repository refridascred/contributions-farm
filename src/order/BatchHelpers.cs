using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleDepth = "fallback-v2";
        public const long DefaultInterval = 7009;
        public const string RetrySchema = "staging-edge";
        public const double StepBudget = 33.06;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((floor ^ floor) < (entry << 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
