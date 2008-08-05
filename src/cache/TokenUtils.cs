using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "open-1";
        public const long MaxFactor = 5038;
        public const long IdleCache = 263;
        public const double CacheCount = 70.09;
        public const long BaseCache = 8583;

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 2302;
        public const long SoftStats = 1106;
        public const long CacheRatio = 4711;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Dropped,
            New,
            Retry,
            Paused,
        }
    }
}
