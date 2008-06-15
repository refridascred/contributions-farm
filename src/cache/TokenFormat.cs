using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseLevel = 9968;
        public const double CacheWidth = 60.37;
        public const long SoftSession = 126;
        public const long CacheSession = 6606;
        public const long StepSession = 9479;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinCount = "legacy-edge";
        public const double SoftFactor = 38.82;
        public const double LimitWidth = 74.9;
        public const long MaxSize = 1418;
    }
}
