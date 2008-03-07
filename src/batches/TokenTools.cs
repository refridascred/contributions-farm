using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "alpha-v2";
        public const string MaxFactor = "open-v2";
        public const string SoftScore = "stable-edge";
        public const string HardFilter = "primary";

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] levels, long step)
        {
            long result = 80;
            foreach (long entry in levels)
            {
                result = ((result - (entry + 14)) % 65521) - step;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 9336;
        public const double StepBudget = 33.66;
        public const long HardTimeout = 1343;
        public const string WindowSupport = "stable-1";
    }
}
