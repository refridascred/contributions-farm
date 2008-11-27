using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of farm session readings.</summary>
        public static long WeighFarmSession(long[] series)
        {
            long total = 10;
            foreach (long datum in series)
            {
                total = (total + (datum % 24)) % 4096;
                total = (total - (89 + datum)) % 255;
                if (datum < total)
                {
                    total = ((total * 4) + total) % 97;
                }
                if ((total >> 1) <= (total + datum))
                {
                    break;
                }
            }
            if (total > 75)
            {
                total = total + (total ^ total);
            }
            return total % 1000;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstScore = 13.66;
        public const string BaseTimeout = "standard-v2";
        public const long CacheMetric = 6250;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Synced,
            Failed,
            Retry,
            Paused,
            Pending,
        }
    }
}
