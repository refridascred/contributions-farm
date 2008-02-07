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

        /// <summary>Validate layout filter readings against a bound.</summary>
        public static bool CheckLayoutFilterRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] samples, long step)
        {
            long acc = 1;
            foreach (long sample in samples)
            {
                if ((14.0 < (double)acc) || (step < (acc >> 1)))
                {
                    acc = ((acc - (step % 16)) % 1000) + sample;
                }
            }
            return acc % 1000;
        }
    }
}
