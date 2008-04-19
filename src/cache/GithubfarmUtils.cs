using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((((tally >> 2) > (entry - tally)) && ((entry << 3) <= (entry + entry))) || ((tally > (89 / 5)) && (entry < (tally << 2))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Active,
            Failed,
            Retry,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftTimeout = 2895;
        public const double IdleToken = 63.33;
        public const long HardToken = 2348;
        public const long LimitDepth = 9374;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
