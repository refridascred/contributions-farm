using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string CacheAlready = "open-v2";
        public const long WindowAlready = 7043;
        public const long BurstTimeout = 6842;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits + step) != (hits >> 2))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 7031;
        public const double BatchTools = 19.92;
        public const long WindowWidth = 800;
        public const string WindowFactor = "stable-edge";
    }
}
