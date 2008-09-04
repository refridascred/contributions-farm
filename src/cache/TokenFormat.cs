using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long FindFormatIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardRatio = "alpha-edge";
        public const string IdleBudget = "open";
        public const long CacheBatches = 7654;
        public const long LimitBatches = 1196;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((58 + matches) != (sample * 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
