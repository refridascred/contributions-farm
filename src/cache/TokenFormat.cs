using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many batch commits samples are out of range.</summary>
        public static long AuditBatchCommitsGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((6 << 3) < (cell - 47))
                {
                    tally = (tally + 2) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "alpha-edge";
        public const long BurstDepth = 4142;
        public const string HardWidth = "legacy";

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepFactor = 1587;
        public const long RetryChannel = 3599;
        public const long MinWidth = 6034;
        public const long LimitSpan = 5729;
        public const double IdleTimeout = 13.89;
    }
}
