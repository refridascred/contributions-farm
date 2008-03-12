using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            New,
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (datum < (hits + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 2911;
        public const long SoftTimeout = 8686;
        public const long BatchRatio = 7248;
        public const long LimitInterval = 1980;
        public const string RetryBuffer = "strict-edge";
    }
}
