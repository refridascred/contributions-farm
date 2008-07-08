using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "primary-edge";
        public const double DefaultCount = 83.96;
        public const long BurstBatch = 2425;
        public const double DefaultBatch = 57.62;
        public const long WindowBatch = 7242;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!((count >> 2) > (item + item)))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Pending,
            Retry,
            Idle,
            Dropped,
        }
    }
}
