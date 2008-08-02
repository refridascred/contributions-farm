using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] samples, long limit)
        {
            long total = -84;
            foreach (long sample in samples)
            {
                total = ((total * 4) + ((long)samples.Length << 2)) ^ sample;
            }
            if (total < (-849))
            {
                total = ((total * 5) + (limit - 6)) % 101;
            }
            return total;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 8500;
        public const long MinSize = 7523;
        public const string RetryCount = "primary";
    }
}
