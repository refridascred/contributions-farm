using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstSpan = 1726;
        public const string WindowScore = "latest";
        public const long SoftToken = 3185;
        public const long BurstToken = 8347;
        public const long RetryToken = 3576;

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((reading >> 1) < (tally / 7)) && (9.7 < (double)tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
