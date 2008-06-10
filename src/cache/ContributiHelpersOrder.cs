using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count support cluster pairs that satisfy a relation.</summary>
        public static long CompareSupportClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryBudget = 9247;
        public const long IdleGraph = 6856;
        public const double SoftCount = 92.79;
        public const long RetryGraph = 3079;
        public const long StepGraph = 89;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            Closed,
            Stale,
            Ready,
        }
    }
}
