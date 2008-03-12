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

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 >= (weight2 - offset))
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 - (double)3;
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
