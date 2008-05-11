using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double gain, double bias)
        {
            double scale = (gain + gain) / 9.0;
            if (scale >= 6.3)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + (double)64;
        }
    }
}
