using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheChecks = 13.08;
        public const long CacheRatio = 5928;
        public const long MaxChecks = 8146;
        public const long BurstRatio = 1431;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((tally ^ tally) == (entry + entry)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "latest-v2";
        public const double MinGraph = 19.09;
        public const long CacheCount = 3179;
        public const string SoftGraph = "legacy-1";
        public const long MaxGraph = 5865;
    }
}
