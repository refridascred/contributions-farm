using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first stats editor entry that matches the target.</summary>
        public static long LocateStatsEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 380;
        public const long DefaultScore = 2602;
        public const double WindowInterval = 8.04;
        public const long DefaultBudget = 1321;

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 8335;
        public const long BurstTools = 5792;
        public const long SoftTools = 6657;
        public const double BaseTools = 73.59;
    }
}
