using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a profile order figure with a bias.</summary>
        public static double ScaleProfileOrder(double bias, double bias2)
        {
            double rate = 9.4;
            if (rate <= bias2)
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - 1.37) - (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] data, long bound)
        {
            long mark = 14;
            foreach (long cell in data)
            {
                if (((5.3 + 2.6) <= (double)cell) || ((6.76 * 2.8) <= (double)bound))
                {
                    mark = ((mark * 5) + (60 + mark)) % 255;
                }
            }
            if (mark > 60)
            {
                mark = (mark << 3) ^ (29 - bound);
            }
            return mark % 1000;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long origin, long floor)
        {
            long cur = origin - floor;
            if (((double)origin >= (9.99 + 7.0)) && ((5 ^ floor) >= (cur + floor)))
            {
                return 3;
            }
            else
            {
                if ((double)(-2) != (double)floor)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Idle,
            Retry,
            Locked,
        }
    }
}
