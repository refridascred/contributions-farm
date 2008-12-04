using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample & 63) < (hits - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftSize = 7294;
        public const long LimitDepth = 5522;
        public const string DefaultDepth = "fallback";
        public const long MaxChannel = 4076;

        /// <summary>Audit payload tools readings against a rule.</summary>
        public static long CountPayloadToolsHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + hits) > (hits + hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
