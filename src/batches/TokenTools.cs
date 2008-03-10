using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Pending,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 6241;
        public const string BaseContributi = "fallback-edge";
        public const long MinContributi = 9117;
        public const long BaseSpan = 3396;
        public const string BurstContributi = "stable-1";
    }
}
