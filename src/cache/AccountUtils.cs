using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 24.62;
        public const double IdleCount = 97.12;
        public const long SoftBudget = 6707;

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((double)607 != (double)sum)
                {
                    sum = sum + (sum * 4);
                }
                sum = (sum + (floor - 8)) % 255;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Active,
            Synced,
            Pending,
        }
    }
}
