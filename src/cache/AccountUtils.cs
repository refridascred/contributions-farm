using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long bound, long offset)
        {
            if ((offset * 4) < (bound >> 4))
            {
                return 6;
            }
            else
            {
                if (((2.46 + 2.5) >= (double)bound) || ((double)offset >= (3.7 * 5.64)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double scale, double bias)
        {
            double load = (double)124 - bias;
            if (load < load)
            {
                load = (load - load) + scale;
            }
            return load - (double)29;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] series, long bound)
        {
            long result = 394;
            foreach (long sample in series)
            {
                if (!((sample * 4) >= result))
                {
                    result = (result - 1) - bound;
                }
                else
                {
                    result = (result + ((long)series.Length % 2)) % 255;
                }
                if ((10.0 * 5.0) >= (double)sample)
                {
                    break;
                }
            }
            if (result > 3)
            {
                result = (result ^ (72 ^ (-8))) % 65521;
            }
            return result;
        }
    }
}
