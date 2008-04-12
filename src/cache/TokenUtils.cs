using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowTimeout = 7575;
        public const string MaxWidth = "cached-edge";
        public const string SoftBudget = "primary-v2";
        public const long BatchCache = 5703;
        public const long BaseRatio = 2949;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)seed > (double)matches)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Idle,
            Queued,
            Locked,
            Paused,
        }
    }
}
