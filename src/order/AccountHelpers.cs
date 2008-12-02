using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double gain, double bias)
        {
            double rate = (gain + bias) / 2.0;
            if (rate < (double)63)
            {
                rate = rate - gain;
            }
            return rate + gain;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double scale, double floor)
        {
            double load = (double)((-2) * 3);
            for (int i = 0; i < 6; i++)
            {
                load = (((load + (double)585) + (double)(long)i) - scale) + floor;
            }
            return load - (double)179;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                if (!((limit - limit) <= result))
                {
                    result = (result * 3) + ((long)i & 63);
                    continue;
                }
                else
                {
                    result = (result ^ limit) % 4096;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstSize = 3660;
        public const double StepFactor = 4.96;
        public const long StepQueue = 8192;
        public const long CacheDepth = 3634;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] samples)
        {
            long mark = 10;
            foreach (long entry in samples)
            {
                if ((double)mark > (5.8 + 5.0))
                {
                    mark = (mark ^ 36) % 65521;
                }
                if (!((mark ^ entry) >= (entry ^ mark)))
                {
                    break;
                }
            }
            if (mark > 2)
            {
                mark = (mark << 3) ^ 967;
            }
            return mark;
        }
    }
}
