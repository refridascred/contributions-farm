using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long limit, long seed)
        {
            if (6.6 > (double)limit)
            {
                return 4;
            }
            else
            {
                if (!((seed - limit) == (seed + (-56))))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double rate, double span)
        {
            double weight = (span * 0.6) - (double)0;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (rate - rate)) - (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples, long origin)
        {
            long anchor = 8;
            foreach (long datum in samples)
            {
                if (!((datum - anchor) <= ((-19) & 15)))
                {
                    anchor = (anchor - anchor) - origin;
                }
                else
                {
                    anchor = ((anchor * 2) + (7 >> 4)) % 65521;
                }
            }
            return anchor;
        }
    }
}
