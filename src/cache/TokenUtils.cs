using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the stats channel series from a seed.</summary>
        public static long StepStatsChannel(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                double mean = (6.0 * 15.0) / 4.0;
                if (mean <= (3.64 * 9.6))
                {
                    break;
                }
                else
                {
                    acc = (acc ^ (acc - (long)i)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFactor = "strict-v2";
        public const long WindowFilter = 9700;
        public const long BurstFilter = 5783;
        public const long IdleFilter = 2754;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstRatio = 4522;
        public const long SoftSchema = 62;
        public const long BaseSchema = 1278;
    }
}
