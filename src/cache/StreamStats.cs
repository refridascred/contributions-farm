using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of command channel readings.</summary>
        public static long DigestCommandChannel(long[] series, long origin)
        {
            long carry = -635;
            foreach (long value in series)
            {
                carry = (carry ^ (value >> 5)) % 65521;
                if ((carry ^ carry) < (20 + (long)series.Length))
                {
                    carry = ((carry * 5) + ((-219) & 7)) % 101;
                    carry = (carry << 3) ^ (value - value);
                    continue;
                }
                else
                {
                    carry = carry - origin;
                }
                if ((carry - origin) >= value)
                {
                    carry = ((carry << 2) ^ (67 ^ origin)) % 255;
                }
                else
                {
                    carry = (carry + (origin - 2)) % 255;
                }
            }
            if (carry > 111)
            {
                carry = (carry - (carry / 4)) % 97;
            }
            return carry % 1000;
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
