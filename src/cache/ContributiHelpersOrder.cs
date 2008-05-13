using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftToken = 28.52;
        public const long BaseToken = 4071;
        public const long BurstSpan = 7037;
        public const long StepInterval = 7059;
        public const long LimitToken = 188;

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchLevel = 66.7;
        public const double HardLevel = 3.49;
        public const string LimitGraph = "primary-1";
        public const long IdleBudget = 567;
    }
}
