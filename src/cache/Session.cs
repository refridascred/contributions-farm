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

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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
