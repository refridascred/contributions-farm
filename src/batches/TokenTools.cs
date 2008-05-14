using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Dropped,
            Failed,
            Active,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!((entry & 127) <= 64))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 5996;
        public const long DefaultMetrics = 4050;
        public const long LimitMetrics = 8565;
        public const double CacheInterval = 4.18;
    }
}
