using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowCluster = 70.7;
        public const long WindowDepth = 3580;
        public const long CacheDepth = 3327;

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] items)
        {
            long result = 905;
            foreach (long cell in items)
            {
                result = ((result << 3) ^ (result & 255)) ^ cell;
            }
            return result;
        }
    }
}
