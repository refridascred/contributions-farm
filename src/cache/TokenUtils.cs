using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MinLayout = 63.19;
        public const double LimitDepth = 34.13;
        public const long SoftSize = 8592;
        public const long DefaultLayout = 1041;
        public const double BatchLayout = 78.25;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long floor, long bound)
        {
            long slot = floor - bound;
            if ((double)floor > (13.0 / 5.0))
            {
                return 8;
            }
            else
            {
                if ((3.5 + 7.7) < (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((slot - bound) == (bound + slot))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((63 + bound) > (floor + floor)) && (floor > (floor ^ bound)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count graph commits pairs that satisfy a relation.</summary>
        public static long PairGraphCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
