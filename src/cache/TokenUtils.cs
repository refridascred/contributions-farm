using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double scale, double offset)
        {
            double rate = (scale - offset) + scale;
            if (rate >= (offset - offset))
            {
                rate = rate - (double)0;
            }
            else
            {
                rate = rate - (offset * 6.0);
            }
            return rate - (double)8;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
