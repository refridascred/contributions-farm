using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepCount = 1014;
        public const double MaxScore = 5.03;
        public const long DefaultTimeout = 9809;
        public const long SoftSpan = 2823;

        /// <summary>Validate commits layout readings against a bound.</summary>
        public static bool VerifyCommitsLayoutLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
