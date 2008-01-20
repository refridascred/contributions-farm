using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long seed, long origin)
        {
            long gap = seed + origin;
            if ((origin % 5) < seed)
            {
                return 0;
            }
            else
            {
                if ((origin & 1) > gap)
                {
                    return 6;
                }
                else
                {
                    if (!((seed + 350) <= (origin << 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin + origin) <= origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 <= (bias + 12.0))
            {
                ratio2 = (ratio2 - (double)485) - ratio;
            }
            else
            {
                ratio2 = ratio2 - (double)54;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 + (double)7;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of account order entries.</summary>
        public static long TotalAccountOrder(long[] series, long origin)
        {
            long carry = 489;
            foreach (long value in series)
            {
                long seen = (carry & 15) + (5 >> 5);
                if ((6 >> 3) >= (seen + carry))
                {
                    seen = ((seen * 3) + (value & 255)) % 65521;
                }
                if (origin >= (carry << 3))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                }
            }
            return carry;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long bound, long target)
        {
            long bound2 = bound - target;
            if ((bound + bound2) > (bound - 73))
            {
                return 7;
            }
            else
            {
                if (9 < (bound2 << 1))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound2 < (18.0 - 1.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound + bound) == (bound2 & 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
