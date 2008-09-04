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

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] levels)
        {
            long state = 7;
            foreach (long value in levels)
            {
                if ((double)value > (3.0 * 17.0))
                {
                    state = ((state * 5) + ((-410) * 5)) % 97;
                }
                else
                {
                    state = state - (value >> 5);
                }
            }
            return state % 1000;
        }
    }
}
