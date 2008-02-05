using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 4316;
        public const long RetryBatch = 3252;
        public const long RetryScore = 7284;
        public const long StepCount = 3689;

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowScore = "cached-1";
        public const double WindowFilter = 18.11;
        public const long CacheCount = 5095;
        public const long IdleWidth = 416;

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] values, long bound)
        {
            long score = 119;
            foreach (long datum in values)
            {
                score = (score ^ (datum + 68)) % 4096;
            }
            if (score < 176)
            {
                score = (score + (bound + score)) % 97;
            }
            return score;
        }
    }
}
