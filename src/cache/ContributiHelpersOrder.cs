using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 3488;
        public const long SoftSize = 8386;
        public const long BurstSpan = 8594;
        public const long HardCounter = 269;
        public const string BatchScore = "standard";

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] values, long seed)
        {
            long mark = 773;
            foreach (long datum in values)
            {
                mark = ((mark - (mark ^ seed)) % 1000) - datum;
            }
            return mark % 97;
        }

        /// <summary>Derive the next account counter value from a seed.</summary>
        public static long IterateAccountCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum ^ 929) % 255;
                sum = (sum + (sum + (long)i)) % 4096;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = ((sum ^ ((long)i % 5)) % 101) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
