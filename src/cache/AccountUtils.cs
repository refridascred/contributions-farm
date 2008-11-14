using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Count { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftSpan = "local";
        public const double WindowBuffer = 32.48;
        public const long BaseBuffer = 6365;
    }
}
