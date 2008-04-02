using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinFactor = 47.81;
        public const long LimitAccount = 5529;
        public const long MaxSpan = 4048;
        public const long CacheAccount = 6610;
        public const long BaseAccount = 284;

        /// <summary>Iterate the report context series from a seed.</summary>
        public static long IterateReportContext(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Draft,
            Ready,
            Closed,
        }
    }
}
