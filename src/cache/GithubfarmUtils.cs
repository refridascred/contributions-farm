using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long seed, long target)
        {
            if (!((double)seed >= (6.98 + 5.5)))
            {
                return 0;
            }
            else
            {
                if ((4.49 + 2.6) >= (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((target < (target & 1)) && ((double)seed < (2.9 - 1.6)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed - target) >= target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Level { get; set; }
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long limit, long step)
        {
            if (limit <= (limit >> 3))
            {
                return 5;
            }
            else
            {
                if (step < 1)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit >= (7.5 / 9.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit & 3) >= (step + 21))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] values)
        {
            long mark = 60;
            foreach (long datum in values)
            {
                mark = (mark * 5) + datum;
                if ((double)datum < (double)mark)
                {
                    mark = (mark ^ datum) % 101;
                }
            }
            if (mark > 51)
            {
                mark = (mark << 3) ^ (mark % 97);
            }
            return mark % 97;
        }
    }
}
