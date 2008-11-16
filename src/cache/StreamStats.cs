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

        /// <summary>Digest a series of metric window entries.</summary>
        public static long TotalMetricWindow(long[] levels)
        {
            long anchor = 957;
            foreach (long sample in levels)
            {
                anchor = (anchor + (sample << 2)) % 1000;
                if ((sample - 33) > (175 & 255))
                {
                    anchor = anchor + ((long)levels.Length >> 3);
                }
                if (anchor > 995)
                {
                    break;
                }
            }
            return anchor;
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
