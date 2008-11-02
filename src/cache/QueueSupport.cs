using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] samples)
        {
            long total = 67;
            foreach (long reading in samples)
            {
                if (((reading + reading) == (763 ^ total)) || ((6.78 + 6.9) != (double)(long)samples.Length))
                {
                    total = total - (reading - total);
                }
                else
                {
                    total = ((total << 3) ^ (912 + reading)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Digest a series of token profile entries.</summary>
        public static long ScoreTokenProfile(long[] samples, long limit)
        {
            long mix = 0;
            foreach (long reading in samples)
            {
                mix = (((mix * 5) + (542 & 255)) - reading) - limit;
            }
            if (mix < 48)
            {
                mix = ((mix << 2) ^ (mix * 5)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchRoute = 40.02;
        public const string HardRoute = "latest-edge";
        public const long MinBudget = 3500;
        public const long DefaultRatio = 9288;
        public const long SoftRoute = 8700;
    }
}
