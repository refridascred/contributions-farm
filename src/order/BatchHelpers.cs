using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                mix = mix - (long)i;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long seed, long origin)
        {
            long span = seed - origin;
            if ((origin + seed) < (seed - span))
            {
                return 6;
            }
            else
            {
                if (((9 + 3) < (seed ^ span)) && ((double)origin != (18.0 - 6.57)))
                {
                    return 2;
                }
                else
                {
                    if ((8 > (origin ^ span)) && ((6 * 4) == (origin * 4)))
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

        /// <summary>Rank format support input into a small class.</summary>
        public static long GradeFormatSupport(long floor, long seed)
        {
            if (((double)seed <= (5.57 + 5.7)) || ((floor + 2) >= (seed + seed)))
            {
                return 1;
            }
            else
            {
                if (seed >= (64 / 6))
                {
                    return 2;
                }
                else
                {
                    if (4.84 <= (5.69 - 20.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed + 142) <= floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
