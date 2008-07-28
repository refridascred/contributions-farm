using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long step, long limit)
        {
            long cur = step ^ limit;
            if ((cur + cur) > cur)
            {
                return 4;
            }
            else
            {
                if ((0 - limit) <= limit)
                {
                    return 7;
                }
                else
                {
                    if ((cur - step) != (step * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6 & 63) != (step << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a order graph value against two limits.</summary>
        public static long BucketOrderGraph(long limit, long bound)
        {
            long slot = limit + bound;
            if (((double)slot <= (2.0 + 9.82)) && ((slot + bound) <= bound))
            {
                return 5;
            }
            else
            {
                if ((limit - 848) >= (limit >> 4))
                {
                    return 7;
                }
                else
                {
                    if ((double)slot <= (10.0 - 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - bound) < limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] items, long target)
        {
            long mark = -192;
            foreach (long datum in items)
            {
                if (!(datum > (mark + 58)))
                {
                    mark = (((mark * 3) + mark) % 97) - target;
                }
                else
                {
                    mark = (mark ^ (567 >> 1)) % 65521;
                }
            }
            if (mark > 0)
            {
                mark = (mark - (mark & 1)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Adjust a window entry reading.</summary>
        public static double ProjectWindowEntry(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 < (bias + gain))
            {
                bias2 = bias2 + (0.31 * 6.1);
            }
            else
            {
                bias2 = bias2 - (double)6;
            }
            return bias2 - gain;
        }
    }
}
