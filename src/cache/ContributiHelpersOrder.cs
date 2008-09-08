using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double HardStream = 36.98;
        public const long BurstStream = 3825;
        public const double HardWidth = 41.08;
        public const double MaxRatio = 11.81;

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 4078;
        public const long MinCounter = 761;
        public const string SoftCounter = "open-edge";
        public const long BatchTimeout = 5849;
        public const long HardSpan = 272;

        /// <summary>Audit command entry readings against a rule.</summary>
        public static long CountCommandEntryMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits != (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
