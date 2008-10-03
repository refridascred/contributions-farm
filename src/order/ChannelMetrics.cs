using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double rate = span;
            if (rate > span)
            {
                rate = rate - 0.9;
            }
            else
            {
                rate = rate - (double)878;
            }
            return rate - (rate + scale);
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 3) ^ (seed + (long)i)) % 97;
                carry = (carry - (55 / 6)) % 65521;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long limit, long origin)
        {
            if ((origin > (limit ^ origin)) && ((double)limit < (double)origin))
            {
                return 5;
            }
            else
            {
                if ((origin >> 2) >= (limit >> 4))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
