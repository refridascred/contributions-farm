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

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 4842;
        public const long CacheProfile = 5612;
        public const long DefaultRatio = 4881;
        public const long IdleProfile = 3875;
        public const long BatchWidth = 3216;

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 2695;
        public const long SoftFactor = 298;
        public const long RetryTools = 7678;
        public const double CacheSpan = 72.76;
    }
}
