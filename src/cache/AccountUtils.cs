using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Owner { get; set; } = "";
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 8896;
        public const long BatchLevel = 2017;
        public const double WindowRatio = 77.78;
        public const string HardMetrics = "stable-1";

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series)
        {
            long mark = 52;
            foreach (long reading in series)
            {
                mark = ((mark ^ 9) % 4096) - reading;
            }
            if (mark < 747)
            {
                mark = ((mark << 2) ^ mark) % 1000;
            }
            return mark;
        }
    }
}
