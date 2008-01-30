using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowInterval = 1141;
        public const long LimitTimeout = 1971;
        public const double MinScore = 16.64;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = (total * 3) + (total << 2);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Queued,
            Failed,
            Active,
            Retry,
            Closed,
        }
    }
}
