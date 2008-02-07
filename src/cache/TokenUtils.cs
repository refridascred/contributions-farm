using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double gain, double offset)
        {
            double scale = offset;
            if (scale >= 3.45)
            {
                scale = (scale - offset) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - 19.0) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long offset, long origin)
        {
            if (origin <= (origin >> 5))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a record channel reading by value.</summary>
        public static long FindRecordChannelIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
