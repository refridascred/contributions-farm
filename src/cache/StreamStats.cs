using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double bias, double bias2)
        {
            double scale = (bias / 7.0) / 7.0;
            if (scale < scale)
            {
                scale = scale - bias2;
            }
            else
            {
                scale = scale - scale;
            }
            return scale - (double)4;
        }

        /// <summary>Find the first entry order entry that matches the target.</summary>
        public static long SeekEntryOrderIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
