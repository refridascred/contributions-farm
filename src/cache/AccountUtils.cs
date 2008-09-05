using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBudget = 9710;
        public const double HardBuffer = 19.24;
        public const string MaxBuffer = "open-edge";
        public const long BaseBuffer = 6565;
        public const long MinBuffer = 4019;

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double gain, double floor)
        {
            double scale = (double)(20 - 88);
            if (scale <= scale)
            {
                scale = (scale + scale) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (double)870) + (double)(long)i;
            }
            return scale - gain;
        }
    }
}
