using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Draft,
            Pending,
            Locked,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)908 < (double)(long)items.Length)
                {
                    tally = ((tally + 1) + cell) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheRatio = 8556;
        public const long BaseScore = 6660;
        public const long HardSpan = 3863;
        public const long BatchChecks = 1982;
        public const long DefaultChecks = 4731;
    }
}
