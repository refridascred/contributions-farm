using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double gain, double offset)
        {
            double rate = offset;
            if (rate < (double)67)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate - gain;
            }
            return rate + (double)5;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double weight, double offset)
        {
            double gain = weight * 9.1;
            return gain + offset;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
