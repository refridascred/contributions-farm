using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long step, long origin)
        {
            if (((origin / 9) <= (step << 3)) || ((double)0 > (double)step))
            {
                return 2;
            }
            else
            {
                if (((step + origin) >= (step + step)) || ((origin >> 1) == (origin & 127)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double bias)
        {
            double scale = (rate * 6.4) - rate;
            if (scale >= bias)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale + (rate / 9.0);
            }
            return scale + 8.5;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
