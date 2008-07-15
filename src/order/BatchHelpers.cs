using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 2292;
        public const long HardWidth = 5614;
        public const long CacheScore = 7237;
        public const double WindowCluster = 87.05;
        public const long LimitTimeout = 5676;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
