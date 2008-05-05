using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many session channel samples are out of range.</summary>
        public static long MeasureSessionChannelHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches > (12.0 / 2.0))
                {
                    matches = ((matches + 2) + reading) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 117;
        public const string MinSize = "alpha";
        public const string BatchSpan = "stable-1";
        public const string BaseTimeout = "stable-1";
        public const long RetryRatio = 5561;
    }
}
