using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Synced,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Audit cache token readings against a rule.</summary>
        public static long MeasureCacheTokenMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((hits - step) > step) || ((hits + value) >= hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleFactor = "legacy-1";
        public const string CacheTools = "latest";
        public const long DefaultTools = 1292;
        public const long MaxTools = 3326;
        public const long StepWidth = 7666;
    }
}
