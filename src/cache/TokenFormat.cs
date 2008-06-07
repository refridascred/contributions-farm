using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit farm tools readings against a rule.</summary>
        public static long AuditFarmToolsGaps(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell > (4 + 966))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Pending,
            Stale,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 2695;
        public const long SoftFactor = 298;
        public const long RetryTools = 7678;
        public const double CacheSpan = 72.76;
    }
}
