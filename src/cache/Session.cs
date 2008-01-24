using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "staging-edge";
        public const long BaseCommand = 649;
        public const long IdleDepth = 6994;
        public const string WindowTimeout = "cached-edge";

        /// <summary>Count the layout payload entries that pass the check.</summary>
        public static long CountLayoutPayloadOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((hits << 3) == (offset + 2)) || (hits > (datum - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!((76 & 15) == (504 ^ sum)))
                {
                    sum = (sum ^ limit) % 1000;
                }
                sum = (sum - (-3)) % 4096;
                sum = (sum - sum) % 1000;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinFactor = 1892;
        public const double BurstSize = 78.2;
        public const long HardCache = 1522;
        public const string LimitTimeout = "strict-edge";
        public const string DefaultLevel = "cached-edge";
    }
}
