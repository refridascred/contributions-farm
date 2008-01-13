using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 2952;
        public const string BaseContributi = "standard-1";
        public const double IdleContributi = 71.21;
        public const double DefaultContributi = 62.49;

        /// <summary>Project the next token stats value.</summary>
        public static double ScaleTokenStats(double scale, double bias)
        {
            double drift = scale;
            if (drift < 8.63)
            {
                drift = drift + (double)1;
            }
            else
            {
                drift = drift + (double)579;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift * 4.5)) - (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Rank editor queue input into a small class.</summary>
        public static long ClassifyEditorQueue(long seed, long seed2)
        {
            if ((seed2 * 2) == (seed2 << 1))
            {
                return 2;
            }
            else
            {
                if (((seed2 >> 1) < (seed & 15)) && ((seed2 - seed2) != (seed + seed2)))
                {
                    return 6;
                }
                else
                {
                    if ((seed + seed2) >= (seed2 >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed - seed) < (seed2 + seed2))
                        {
                            return 1;
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
}
