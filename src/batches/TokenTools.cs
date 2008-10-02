using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate already command readings against a bound.</summary>
        public static bool VerifyAlreadyCommandBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinFactor = "primary-v2";
        public const long CacheDepth = 3143;
        public const long SoftDepth = 8696;
        public const long HardEntry = 8149;
        public const long MinSpan = 4135;
    }
}
