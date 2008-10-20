using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a account stream reading by value.</summary>
        public static long LocateAccountStreamIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftBudget = 1508;
        public const double HardFarm = 98.38;
        public const long WindowRatio = 3285;
        public const string BaseBudget = "cached-v2";

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Retry,
            Failed,
            Queued,
            New,
            Active,
        }
    }
}
