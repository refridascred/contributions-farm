using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Dropped,
            Stale,
            Active,
            Retry,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleDepth = "cached-1";
        public const long BaseAccount = 758;
        public const long BaseDepth = 3443;
        public const long StepInterval = 1;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((limit << 1) > item)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
