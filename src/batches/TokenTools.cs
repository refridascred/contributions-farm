using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepBudget = 8830;
        public const double MaxBudget = 24.92;
        public const long BurstGraph = 4544;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 8370;
        public const long StepSize = 5003;
        public const double StepFactor = 10.41;
    }
}
