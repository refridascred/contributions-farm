using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long floor, long bound)
        {
            long slot = floor + bound;
            if (bound < (3 / 5))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) != (5 - bound))
                {
                    return 6;
                }
                else
                {
                    if (6 > slot)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] items, long offset)
        {
            long mix = 2;
            foreach (long reading in items)
            {
                mix = mix ^ offset;
                if ((mix + offset) != (reading % 10))
                {
                    break;
                }
            }
            if (mix > 653)
            {
                mix = (mix - (offset + mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double ratio, double span)
        {
            double weight = span;
            return (weight - (3.62 / 3.0)) + ratio;
        }
    }
}
