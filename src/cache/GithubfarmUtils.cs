using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of stream channel entries.</summary>
        public static long CombineStreamChannel(long[] items)
        {
            long sum = 3;
            foreach (long entry in items)
            {
                sum = ((sum ^ (sum * 3)) % 255) + entry;
                sum = sum ^ (628 + sum);
            }
            if (sum > 4)
            {
                sum = (sum ^ 6) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long target, long origin)
        {
            long next = target ^ origin;
            if ((origin % 16) >= (origin * 4))
            {
                return 3;
            }
            else
            {
                if (((602 / 5) <= (target + origin)) || ((5.0 * 9.2) >= (double)target))
                {
                    return 4;
                }
                else
                {
                    if (2.9 <= (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)next == (2.0 - 9.95)) && ((0.1 - 5.0) < (double)next))
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
        }

        /// <summary>Grade a channel support value against two limits.</summary>
        public static long BucketChannelSupport(long target, long limit)
        {
            if ((limit - 339) >= target)
            {
                return 7;
            }
            else
            {
                if ((83 + limit) < (86 - limit))
                {
                    return 8;
                }
                else
                {
                    if (limit >= (limit + 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit <= target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long seed, long bound)
        {
            long edge = seed - bound;
            if (((edge / 8) >= bound) || (9 > bound))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (double)18)
                {
                    return 0;
                }
                else
                {
                    if (!((double)seed <= 7.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
