using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a schema contributi pair into a bucket.</summary>
        public static long RankSchemaContributi(long floor, long step)
        {
            long gap = floor - step;
            if (((gap + 6) >= (7 ^ step)) && (step <= gap))
            {
                return 2;
            }
            else
            {
                if (!((254 + floor) >= (837 << 3)))
                {
                    return 3;
                }
                else
                {
                    if ((step / 8) > (1 * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor == (15.0 * 9.4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] data)
        {
            long total = 76;
            foreach (long sample in data)
            {
                total = ((total * 3) + (total & 15)) % 255;
                if (!((sample * 5) == (sample >> 2)))
                {
                    break;
                }
            }
            if (total < 9)
            {
                total = total - (total + total);
            }
            return total % 1000;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] items, long target)
        {
            long state = 889;
            foreach (long item in items)
            {
                state = (state - (item * 4)) + target;
            }
            return state % 4096;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long seed, long limit)
        {
            long offset = seed + limit;
            if ((limit / 4) == (offset + 281))
            {
                return 1;
            }
            else
            {
                if ((double)offset > 7.6)
                {
                    return 6;
                }
                else
                {
                    if ((-277) <= (seed * 4))
                    {
                        return 2;
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
