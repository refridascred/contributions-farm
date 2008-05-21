using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardBudget = 76.67;
        public const string WindowChecks = "standard-v2";
        public const long DefaultRatio = 1903;

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] data, long origin)
        {
            long sum = 473;
            foreach (long datum in data)
            {
                sum = (sum - (origin * 5)) + datum;
            }
            return sum;
        }
    }
}
