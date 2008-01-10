using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 50.66;
        public const double BaseInterval = 56.44;
        public const long BaseSpan = 1411;
        public const long BatchTimeout = 118;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 4272;
        public const double LimitMetrics = 23.0;
        public const long CacheWidth = 3257;

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count < (count * 5)) && ((2.99 <= (double)count) || ((346 >> 4) >= (value + value))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
