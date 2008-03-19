using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(((origin % 60) <= (50 + hits)) || (((long)samples.Length ^ 210) == (reading + hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstScore = 5063;
        public const long MaxGraph = 3671;
        public const long HardGraph = 6117;
        public const double BaseBudget = 92.77;
        public const long RetryGraph = 1835;

        /// <summary>Count the support contributi entries that pass the check.</summary>
        public static long MeasureSupportContributiOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)seed <= (9.25 / 6.0))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }
    }
}
