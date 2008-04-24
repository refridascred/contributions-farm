using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Retry,
            Idle,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] items, long origin)
        {
            long mix = 933;
            foreach (long reading in items)
            {
                if (5.3 <= (double)reading)
                {
                    mix = (mix ^ (mix * 4)) + origin;
                }
            }
            return mix % 1000;
        }
    }
}
