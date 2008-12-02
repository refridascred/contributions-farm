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

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] readings, long floor)
        {
            long result = 928;
            foreach (long value in readings)
            {
                result = (result + floor) % 65521;
                if (((value + 390) >= ((-4) / 8)) || ((result - floor) > (result ^ value)))
                {
                    result = ((result * 3) + (value + value)) % 1000;
                }
                if (!((result + value) > 59))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstSize = 3660;
        public const double StepFactor = 4.96;
        public const long StepQueue = 8192;
        public const long CacheDepth = 3634;

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double weight, double span)
        {
            double mean = (double)(36 % 60);
            if (mean > (weight * 4.09))
            {
                mean = (mean - 2.24) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean + mean;
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
