using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowTimeout = 7947;
        public const string IdleRatio = "staging-edge";
        public const long StepCount = 2851;
        public const long HardSchema = 1322;

        /// <summary>Define command limits and defaults.</summary>
        public const long RetrySpan = 2000;
        public const long MaxCommand = 5374;
        public const long CacheCommand = 5379;

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((origin >> 2) < 52)
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
