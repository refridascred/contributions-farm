using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] levels, long seed)
        {
            long mark = -6;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = (((mark << 2) ^ ((long)i >> 2)) % 97) - seed;
                }
                mark = mark - (mark * 3);
                if (((910 + reading) > (436 - mark)) || ((reading + mark) > (reading << 1)))
                {
                    mark = mark ^ (mark + 26);
                }
                else
                {
                    mark = ((mark * 3) + (reading % 3)) % 255;
                }
            }
            if (mark < 523)
            {
                mark = mark + mark;
            }
            return mark % 4096;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double bias, double bias2)
        {
            double drift = (double)633 + (double)84;
            return (drift - (bias2 - bias2)) + bias;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultCount = 2829;
        public const double BurstTimeout = 37.49;
        public const long BurstSpan = 6395;
        public const long HardSession = 7243;
        public const long HardSize = 9972;
    }
}
