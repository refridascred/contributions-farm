using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] data, long offset)
        {
            long result = 858;
            foreach (long item in data)
            {
                result = (result + (offset & 7)) + item;
            }
            return result;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 23.86;
        public const long CacheToken = 6182;
        public const string MinToken = "primary";
        public const double SoftSpan = 91.8;
    }
}
