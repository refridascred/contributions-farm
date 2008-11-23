using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheCounter = "open-v2";
        public const long BurstFactor = 1177;
        public const string IdleCounter = "staging-edge";
        public const long LimitDepth = 2582;

        /// <summary>Check that every checks filter entry stays within the limit.</summary>
        public static bool GuardChecksFilterRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((817 <= (seen - offset)) || (value < (value * 2)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
