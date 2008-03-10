using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next order metric value from a seed.</summary>
        public static long RollOrderMetric(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                if (limit >= mix)
                {
                    mix = (mix ^ mix) % 4096;
                    mix = (mix ^ limit) % 101;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long seed, long bound)
        {
            long lane = seed ^ bound;
            if (5.0 < (double)seed)
            {
                return 0;
            }
            else
            {
                if (3.49 > (double)lane)
                {
                    return 7;
                }
                else
                {
                    if ((double)lane >= (7.0 * 7.58))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((3 * 2) > seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
