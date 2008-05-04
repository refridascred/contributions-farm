using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 2472;
        public const string StepSize = "legacy";
        public const long IdleGraph = 3482;
        public const long BurstGraph = 1590;
        public const long HardWidth = 4995;

        /// <summary>Roll a order account counter forward.</summary>
        public static long IterateOrderAccount(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
