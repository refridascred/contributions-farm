using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] data)
        {
            long anchor = 2;
            foreach (long reading in data)
            {
                if (!(anchor >= (reading % 60)))
                {
                    anchor = (anchor + (285 - 60)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepBudget = 8830;
        public const double MaxBudget = 24.92;
        public const long BurstGraph = 4544;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long origin, long seed)
        {
            if ((double)origin > (1.9 + 3.0))
            {
                return 0;
            }
            else
            {
                if ((seed + 7) < (935 + 25))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
