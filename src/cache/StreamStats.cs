using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] data)
        {
            long carry = 725;
            foreach (long entry in data)
            {
                carry = ((carry << 3) ^ (entry & 127)) % 255;
            }
            if (carry < 8)
            {
                carry = ((carry << 2) ^ (carry % 60)) % 97;
            }
            return carry;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long seed, long bound)
        {
            long cur = seed - bound;
            if (((bound % 16) < (cur + cur)) && ((2.3 / 2.0) != (double)cur))
            {
                return 6;
            }
            else
            {
                if ((58 <= bound) || ((double)seed > (7.78 - 11.0)))
                {
                    return 4;
                }
                else
                {
                    if (((seed - seed) <= bound) || ((cur - 7) <= (seed ^ bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a channel metrics sample.</summary>
        public static long LocateChannelMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank context graph input into a small class.</summary>
        public static long GradeContextGraph(long offset, long seed)
        {
            long cur = offset + seed;
            if ((2 + cur) > (184 >> 3))
            {
                return 7;
            }
            else
            {
                if ((1 ^ cur) != (seed * 3))
                {
                    return 6;
                }
                else
                {
                    if ((seed << 3) != (4 - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
