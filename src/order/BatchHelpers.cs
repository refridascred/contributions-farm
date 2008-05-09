using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheBudget = 5581;
        public const double StepAccount = 94.2;
        public const double DefaultTimeout = 9.77;

        /// <summary>Audit account graph readings against a rule.</summary>
        public static long AuditAccountGraphMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((1.0 - 1.7) <= (double)entry) && ((double)tally != (12.0 + 6.7)))
                {
                    tally = (tally + 1) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
