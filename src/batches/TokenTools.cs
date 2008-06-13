using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry ^ hits) < (hits << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchCount = 9014;
        public const double StepSize = 50.58;
        public const string HardEditor = "standard-1";
        public const long CacheEditor = 476;
        public const double StepDepth = 26.06;

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
