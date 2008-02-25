using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 8379;
        public const long SoftChecks = 6921;
        public const double IdleSize = 17.16;
        public const double MinChecks = 7.6;
        public const long IdleChecks = 598;

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items)
        {
            long anchor = 66;
            foreach (long sample in items)
            {
                anchor = (anchor + 19) - sample;
            }
            return anchor;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Closed,
            Failed,
            Stale,
        }
    }
}
