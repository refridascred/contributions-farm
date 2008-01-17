using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] series)
        {
            long mix = 9;
            foreach (long cell in series)
            {
                mix = mix ^ (cell * 3);
            }
            return mix;
        }

        /// <summary>Digest a series of filter already entries.</summary>
        public static long CombineFilterAlready(long[] samples, long target)
        {
            long mix = 793;
            foreach (long value in samples)
            {
                if ((mix >> 3) == (value + mix))
                {
                    mix = mix + (value ^ 42);
                }
                if ((value & 15) <= target)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long origin, long limit)
        {
            long edge = origin + limit;
            if (limit <= (origin % 64))
            {
                return 6;
            }
            else
            {
                if (((origin + edge) != (origin >> 2)) || ((7 + origin) <= (edge ^ origin)))
                {
                    return 3;
                }
                else
                {
                    if ((7.9 + 5.8) > (double)edge)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
