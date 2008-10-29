using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double scale, double span)
        {
            double mean = 18.0 * 0.82;
            if (mean >= (span - 9.79))
            {
                mean = mean - (scale * 5.9);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean + (span - scale);
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double scale, double floor)
        {
            double mean = (double)(9 + 4);
            if (mean < (double)3)
            {
                mean = (mean + (double)3) - floor;
            }
            return mean - scale;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double ratio, double floor)
        {
            double ratio2 = floor - (ratio - ratio);
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - ratio) + (double)(long)i;
            }
            return ratio2 + (floor + 0.13);
        }
    }
}
