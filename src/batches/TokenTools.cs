using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((bound >> 3) < bound) || ((double)tally > 20.0)) && ((999 & 3) <= (reading ^ 899)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 6848;
        public const double BatchLevel = 1.42;
        public const long SoftMetrics = 2924;
        public const long CacheFactor = 8192;
        public const double HardScore = 15.79;
    }
}
