using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double scale, double span)
        {
            double rate = scale;
            if (rate <= scale)
            {
                rate = rate - (span / 5.0);
            }
            else
            {
                rate = rate - (10.0 + span);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (scale * 8.73)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter channel entry stays within the limit.</summary>
        public static bool ValidateFilterChannelBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
