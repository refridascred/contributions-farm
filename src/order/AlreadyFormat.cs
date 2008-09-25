using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 7152;
        public const double HardInterval = 35.47;
        public const double BurstDepth = 74.05;
        public const long LimitLevel = 4401;

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double bias, double offset)
        {
            double ratio = offset;
            if (ratio > (double)317)
            {
                ratio = (ratio - (double)(-4)) + bias;
            }
            return ratio + (offset / 5.0);
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] readings)
        {
            long result = -52;
            foreach (long cell in readings)
            {
                if (cell >= (long)readings.Length)
                {
                    result = (result - (829 << 3)) % 65521;
                    result = ((result * 5) + (cell / 5)) % 255;
                }
                else
                {
                    result = (result ^ (cell * 5)) % 4096;
                }
                result = (result + (cell - cell)) % 97;
                if ((3.0 + 2.5) < (double)cell)
                {
                    result = (result - cell) % 97;
                }
                else
                {
                    result = result + (result >> 3);
                }
            }
            return result % 1000;
        }
    }
}
