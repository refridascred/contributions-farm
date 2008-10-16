using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 95;
        public const long HardSession = 2528;
        public const long BatchScore = 1314;
        public const string IdleSession = "stable-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const string SoftGraph = "alpha-v2";
        public const string IdleGraph = "stable-v2";
        public const long LimitGraph = 9760;
    }
}
