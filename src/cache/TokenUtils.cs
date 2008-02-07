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

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
