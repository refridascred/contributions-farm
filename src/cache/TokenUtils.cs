using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseWidth = 2777;
        public const double StepEditor = 86.6;
        public const long StepRatio = 9007;
        public const long DefaultBudget = 6705;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Mode { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Rank graph farm input into a small class.</summary>
        public static long SortGraphFarm(long floor, long seed)
        {
            if ((double)seed <= (7.0 - 9.58))
            {
                return 6;
            }
            else
            {
                if (((floor + floor) > (27 / 5)) && ((double)seed <= (9.13 / 9.0)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
