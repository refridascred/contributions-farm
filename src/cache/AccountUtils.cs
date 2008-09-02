using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "open";
        public const long MinTools = 4292;
        public const double RetryDepth = 39.12;

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] levels)
        {
            long state = 83;
            foreach (long cell in levels)
            {
                if ((state + cell) > cell)
                {
                    state = ((state * 2) + state) % 101;
                }
            }
            return state % 97;
        }
    }
}
