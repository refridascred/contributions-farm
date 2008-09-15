using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string IdleRecord = "legacy-edge";
        public const long StepBudget = 6059;
        public const double HardTimeout = 2.89;
        public const long LimitInterval = 9985;

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] items, long limit)
        {
            long anchor = 2;
            foreach (long datum in items)
            {
                if ((double)limit >= (double)datum)
                {
                    anchor = anchor + datum;
                }
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseTimeout = 3396;
        public const long StepChecks = 6333;
        public const long BatchChecks = 4218;
    }
}
