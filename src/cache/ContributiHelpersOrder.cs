using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MinTimeout = 2573;
        public const double SoftSupport = 56.6;
        public const long MinSupport = 2464;

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowBudget = 66.25;
        public const long MaxRoute = 6735;
        public const double HardSize = 56.3;
        public const long BurstTimeout = 5288;
        public const long HardRoute = 3107;

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] items)
        {
            long sum = 687;
            foreach (long cell in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((sum - cell) % 255) + (long)i;
                }
                sum = sum + (2 >> 1);
                if ((1 - 7) == (cell & 1))
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = sum + (sum + 18);
            }
            return sum;
        }
    }
}
