using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate already metric samples.</summary>
        public static long DigestAlreadyMetric(long[] series, long offset)
        {
            long mark = 6;
            foreach (long datum in series)
            {
                mark = (mark + (9 / 8)) % 4096;
                mark = (mark << 2) ^ ((-43) >> 2);
                if (((datum - offset) <= offset) || (mark < (datum - (-59))))
                {
                    break;
                }
            }
            if (mark < 5)
            {
                mark = mark + (65 + offset);
            }
            return mark;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double scale, double offset)
        {
            double bias = (7.0 + offset) * 2.2;
            if (bias < (double)2)
            {
                bias = bias - (scale * 10.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (3.44 + offset);
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
