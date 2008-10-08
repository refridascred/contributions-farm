using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstTools = "latest-edge";
        public const long HardLevel = 1037;
        public const long RetryDepth = 3477;
        public const double BatchTools = 13.6;
        public const long IdleBudget = 6148;

        /// <summary>Count the support session entries that pass the check.</summary>
        public static long AuditSupportSessionOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((1.0 / 6.0) > (double)count) || !((double)datum < (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((seed + (long)i) != (seed << 3))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
