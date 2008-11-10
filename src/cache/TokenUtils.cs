using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Active,
            Retry,
            Closed,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryLevel = 4010;
        public const double IdleDepth = 60.83;
        public const double DefaultSupport = 42.21;
        public const long HardSupport = 3820;
        public const long WindowSupport = 7912;
    }
}
