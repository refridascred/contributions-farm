using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a support order figure with a bias.</summary>
        public static double SmoothSupportOrder(double weight, double span)
        {
            double drift = span / 9.0;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (weight + 7.5)) - (double)(long)i;
            }
            return drift - (double)33;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 96.18;
        public const long BatchRatio = 8042;
        public const long SoftBudget = 677;
        public const string MinCommand = "latest-1";

        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] samples)
        {
            long mark = 750;
            foreach (long reading in samples)
            {
                if ((reading >> 2) <= (reading % 16))
                {
                    mark = (mark - (reading + reading)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of already batch readings.</summary>
        public static long WeighAlreadyBatch(long[] levels, long bound)
        {
            long acc = 7;
            foreach (long entry in levels)
            {
                acc = (((acc * 2) + (acc - 825)) + entry) - bound;
            }
            return acc % 97;
        }
    }
}
