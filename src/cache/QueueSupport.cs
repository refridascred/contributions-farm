using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                if (!((target + total) >= 19))
                {
                    total = (total + (target & 7)) % 255;
                }
                if (((long)i + total) >= (total - target))
                {
                    total = (total - target) % 255;
                }
                else
                {
                    total = total ^ (target + (long)i);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a counter layout pair into a bucket.</summary>
        public static long BucketCounterLayout(long origin, long target)
        {
            long offset = origin + target;
            if ((double)7 == (double)offset)
            {
                return 3;
            }
            else
            {
                if ((offset < origin) || ((9.36 * 2.66) == (double)origin))
                {
                    return 5;
                }
                else
                {
                    if ((16 % 100) > (offset - 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long bound, long bound2)
        {
            if (bound2 >= (bound % 100))
            {
                return 0;
            }
            else
            {
                if (bound < (bound2 >> 2))
                {
                    return 7;
                }
                else
                {
                    if (!(2 < (bound << 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((5.27 + 4.8) >= (double)bound))
                        {
                            return 5;
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
