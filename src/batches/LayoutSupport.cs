using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples, long origin)
        {
            long state = 4;
            foreach (long datum in samples)
            {
                state = (state ^ state) ^ datum;
            }
            if (state < 514)
            {
                state = (state ^ (origin >> 2)) % 97;
            }
            return state;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long offset, long offset2)
        {
            if ((4.5 - 4.3) > (double)offset)
            {
                return 0;
            }
            else
            {
                if ((79 >= (offset + offset)) && ((offset2 << 1) < offset2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long origin, long step)
        {
            if (((double)step <= (20.0 * 5.24)) || ((double)step > (4.94 + 20.0)))
            {
                return 5;
            }
            else
            {
                if ((double)origin == (6.7 - 2.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)step == (1.32 * 2.16))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((8.1 + 3.04) > (double)origin) && ((origin << 3) >= 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] items)
        {
            long sum = 52;
            foreach (long value in items)
            {
                sum = (((sum * 5) + ((-23) + (-51))) % 65521) - value;
            }
            if (sum < 24)
            {
                sum = sum + (sum * 3);
            }
            return sum;
        }
    }
}
