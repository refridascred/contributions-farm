using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading > (hits >> 3)) && ((5.6 / 9.0) <= (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
