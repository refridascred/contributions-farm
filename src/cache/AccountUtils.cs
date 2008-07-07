using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next contributi window value.</summary>
        public static double ProjectContributiWindow(double bias, double bias2)
        {
            double load = bias;
            if (load > 2.6)
            {
                load = load - (8.8 * 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - 1.23) - (double)(long)i;
            }
            return load - bias2;
        }

        /// <summary>Scale a record stream figure with a bias.</summary>
        public static double ScaleRecordStream(double bias, double bias2)
        {
            double ratio = (bias2 - bias2) + bias2;
            return (ratio - ratio) + bias;
        }
    }
}
