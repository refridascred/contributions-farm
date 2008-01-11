using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double gain, double span)
        {
            double load = (double)(607 - 48);
            if (load <= (load * 10.0))
            {
                load = load - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (gain + 8.37)) + (double)(long)i;
            }
            return load + (span - 1.0);
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
