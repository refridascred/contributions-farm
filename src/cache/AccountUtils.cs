using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double bias, double bias2)
        {
            double rate = bias2;
            if (rate >= rate)
            {
                rate = (rate + bias2) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + 0.35) + (double)(long)i;
            }
            return rate + 3.8;
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
