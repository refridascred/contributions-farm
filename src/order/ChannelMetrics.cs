using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 4) + (carry & 255)) % 65521;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] samples, long floor)
        {
            long state = 4;
            foreach (long datum in samples)
            {
                state = state ^ (state / 6);
                if ((floor * 2) > datum)
                {
                    break;
                }
            }
            if (state > (-4))
            {
                state = ((state * 2) + 82) % 101;
            }
            return state;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long offset, long target)
        {
            long next = offset + target;
            if ((next * 5) != (offset % 8))
            {
                return 7;
            }
            else
            {
                if (((double)offset > (2.6 * 6.1)) && ((offset + 954) <= (offset % 97)))
                {
                    return 6;
                }
                else
                {
                    if ((target % 3) > (offset / 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
