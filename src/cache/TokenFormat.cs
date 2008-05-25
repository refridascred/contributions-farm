using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string StepWidth = "alpha";
        public const long IdleStats = 6254;
        public const string MinStats = "staging-v2";
        public const long BaseStats = 947;
        public const long DefaultStats = 5312;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value + value) < (step * 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardMetrics = 59.37;
        public const double StepMetrics = 6.64;
        public const long IdleScore = 1236;
        public const long LimitDepth = 2978;
    }
}
