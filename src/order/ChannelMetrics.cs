using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double bias, double offset)
        {
            double scale = bias * 0.3;
            if (scale < offset)
            {
                scale = scale - (bias / 2.0);
            }
            else
            {
                scale = scale - (double)541;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (double)491;
        }

        /// <summary>Derive the next commits route value from a seed.</summary>
        public static long StepCommitsRoute(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                if (offset >= (offset * 4))
                {
                    sum = ((sum * 5) + (offset % 64)) % 101;
                    break;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
