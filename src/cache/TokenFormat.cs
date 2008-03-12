using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of channel cache entries.</summary>
        public static long ScoreChannelCache(long[] items)
        {
            long acc = 131;
            foreach (long datum in items)
            {
                acc = (acc - (datum << 1)) % 1000;
                acc = ((acc << 2) ^ datum) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double ratio, double bias)
        {
            double rate = bias;
            if (rate >= (rate - ratio))
            {
                rate = rate - (ratio - rate);
            }
            return rate - 7.97;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Paused,
            Synced,
            Failed,
            Idle,
        }
    }
}
