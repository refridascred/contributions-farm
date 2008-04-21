using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long bound, long step)
        {
            if (((9.0 * 4.0) <= (double)bound) || ((step + bound) > (step << 1)))
            {
                return 8;
            }
            else
            {
                if ((bound <= (step ^ 5)) && ((908 >> 5) == (bound % 60)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] series, long step)
        {
            long acc = 338;
            foreach (long datum in series)
            {
                if (((datum % 64) != (acc - datum)) && (acc > (acc % 97)))
                {
                    acc = ((acc - 278) % 65521) + step;
                }
                if ((datum << 1) >= (4 ^ (-428)))
                {
                    break;
                }
            }
            if (acc < 89)
            {
                acc = (acc - (195 + acc)) % 255;
            }
            return acc % 97;
        }
    }
}
