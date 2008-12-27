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

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 920;
        public const string BaseEntry = "standard-v2";
        public const long MinEntry = 4303;

        /// <summary>Classify a support route pair into a bucket.</summary>
        public static long ClassifySupportRoute(long seed, long offset)
        {
            long prev = seed + offset;
            if ((15.0 + 2.49) == (double)offset)
            {
                return 0;
            }
            else
            {
                if (((offset - offset) >= offset) && ((4.34 - 13.0) < (double)prev))
                {
                    return 4;
                }
                else
                {
                    if ((offset - seed) < offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
