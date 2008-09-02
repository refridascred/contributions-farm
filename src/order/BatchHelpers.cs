using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            New,
            Paused,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (cell < seen)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 3674;
        public const string LimitSupport = "fallback-1";
        public const long BaseSupport = 1244;
        public const double WindowSupport = 47.66;
        public const long SoftWidth = 3357;
    }
}
