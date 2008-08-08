using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Locate a cluster token reading by value.</summary>
        public static long LookupClusterTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseFactor = "legacy";
        public const long IdleScore = 3695;
        public const double HardCount = 16.51;

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 227;
        public const long BaseBudget = 7632;
        public const long WindowQueue = 5790;
        public const string SoftQueue = "primary-edge";
    }
}
