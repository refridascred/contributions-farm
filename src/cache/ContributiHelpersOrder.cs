using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] series, long step)
        {
            long acc = -809;
            foreach (long reading in series)
            {
                acc = (acc + (reading - 4)) - step;
            }
            return acc;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] samples, long target)
        {
            long total = 674;
            foreach (long value in samples)
            {
                total = (total - (0 - value)) + target;
                total = (total << 2) ^ (total % 60);
                total = (total ^ (value / 3)) % 255;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardLevel = 1210;
        public const string RetryWidth = "fallback-1";
        public const long WindowFactor = 5602;
        public const long WindowWidth = 7285;
    }
}
