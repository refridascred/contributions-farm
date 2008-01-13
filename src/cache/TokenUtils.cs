using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((9.02 >= (double)value) || ((tally % 7) > (value + tally))) && (tally >= 53))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

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
