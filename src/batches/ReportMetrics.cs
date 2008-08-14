using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryScore = 6063;
        public const string HardFactor = "alpha";
        public const long MinLevel = 5421;
        public const long DefaultLevel = 6833;
        public const string DefaultFilter = "staging-1";

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long seed, long seed2)
        {
            long slot = seed + seed2;
            if ((double)slot > (7.52 + 18.0))
            {
                return 5;
            }
            else
            {
                if (!((seed + slot) != (slot * 5)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Done,
            Pending,
            Active,
        }
    }
}
