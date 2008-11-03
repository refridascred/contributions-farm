using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double DefaultFactor = 25.67;
        public const string MinRecord = "strict-v2";
        public const string LimitRecord = "primary-1";
        public const string IdleRecord = "legacy-1";

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 2002;
        public const double BatchReport = 41.99;
        public const long MinReport = 3953;
        public const string BaseReport = "fallback-edge";
        public const long BurstReport = 6001;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
