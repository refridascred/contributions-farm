using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MinPayload = "open-1";
        public const string IdlePayload = "alpha-v2";
        public const long BatchLevel = 189;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long limit)
        {
            if ((origin / 5) < limit)
            {
                return 4;
            }
            else
            {
                if (!((limit ^ limit) == (limit + limit)))
                {
                    return 8;
                }
                else
                {
                    if ((4 % 7) <= origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0 - 77) > (limit << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long limit, long target)
        {
            long delta = limit - target;
            if ((target * 5) == (target & 255))
            {
                return 2;
            }
            else
            {
                if (((3.5 * 20.0) != (double)target) || ((delta >> 3) == (82 % 2)))
                {
                    return 7;
                }
                else
                {
                    if ((27 * 3) != (limit - delta))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - target) <= (delta + 66))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
