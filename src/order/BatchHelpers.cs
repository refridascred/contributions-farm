using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 5038;
        public const double LimitFormat = 32.26;
        public const long RetryFormat = 7741;
        public const long HardSpan = 6560;

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] series, long bound)
        {
            long mark = 269;
            foreach (long value in series)
            {
                mark = ((mark + 362) - value) - bound;
            }
            return mark;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseRatio = 3335;
        public const long StepEntry = 4578;
        public const long DefaultEntry = 4815;
        public const long HardCount = 1812;
    }
}
