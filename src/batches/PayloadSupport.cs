using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 < ratio2)
            {
                ratio2 = ratio2 - (double)3;
            }
            else
            {
                ratio2 = ratio2 + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - (ratio * 8.59)) + (double)(long)i;
            }
            return ratio2 - (bias - ratio);
        }

        /// <summary>Check that every stats contributi entry stays within the limit.</summary>
        public static bool ValidateStatsContributiLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
