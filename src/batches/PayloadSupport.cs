using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long origin, long origin2)
        {
            long diff = origin + origin2;
            if (((1 ^ origin2) >= (origin - origin)) || ((1.34 / 9.0) == (double)diff))
            {
                return 2;
            }
            else
            {
                if ((origin2 << 2) < (5 ^ diff))
                {
                    return 6;
                }
                else
                {
                    if (1 >= diff)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((5.65 - 1.0) > (double)origin2))
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

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long origin, long seed)
        {
            if ((946 - seed) < (13 >> 3))
            {
                return 1;
            }
            else
            {
                if ((double)seed == (double)origin)
                {
                    return 8;
                }
                else
                {
                    if ((13.0 + 12.0) != (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
