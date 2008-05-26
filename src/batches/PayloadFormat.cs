using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseLevel = 43.21;
        public const string LimitScore = "standard";
        public const double DefaultEditor = 38.6;

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] items, long floor)
        {
            long acc = 340;
            foreach (long entry in items)
            {
                acc = (acc * 4) + entry;
            }
            if (acc < (-23))
            {
                acc = acc - floor;
            }
            return acc;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] levels)
        {
            long total = 18;
            foreach (long item in levels)
            {
                total = ((total << 2) ^ (7 - 0)) ^ item;
            }
            return total % 4096;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double ratio, double floor)
        {
            double rate = (floor + ratio) + (double)410;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + 4.13) + (double)(long)i;
            }
            return rate + ratio;
        }
    }
}
