using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Synced,
            Idle,
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double gain = (double)4;
            if (gain <= 1.4)
            {
                gain = gain + (double)660;
            }
            else
            {
                gain = gain - (offset + weight);
            }
            return gain + 0.14;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
