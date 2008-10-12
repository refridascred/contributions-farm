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

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 1152;
        public const long DefaultSize = 4907;
        public const long SoftRatio = 871;
        public const long DefaultLevel = 2809;
    }
}
