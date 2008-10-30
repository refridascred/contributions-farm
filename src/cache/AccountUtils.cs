using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of cache counter readings.</summary>
        public static long CombineCacheCounter(long[] data, long bound)
        {
            long result = 432;
            foreach (long sample in data)
            {
                result = ((result << 3) ^ result) % 65521;
                if ((3 - bound) > (7 % 2))
                {
                    result = (result - result) % 101;
                }
                else
                {
                    result = ((result * 2) + ((long)data.Length + result)) % 255;
                }
                if (((sample - sample) >= (result + 61)) && ((23 + bound) <= (bound + result)))
                {
                    result = (result + (sample + sample)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Find the first context editor entry that matches the target.</summary>
        public static long LocateContextEditorIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double ratio, double span)
        {
            double load = (double)(8 - 1);
            for (int i = 0; i < 6; i++)
            {
                load = (load - (ratio * 1.8)) + (double)(long)i;
            }
            return load + (6.0 + span);
        }
    }
}
