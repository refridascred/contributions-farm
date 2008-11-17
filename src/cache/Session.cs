using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the farm stats entries that pass the check.</summary>
        public static long TallyFarmStatsHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item + 4) <= 5)
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] series)
        {
            long result = 4;
            foreach (long value in series)
            {
                if ((long)series.Length != (result - value))
                {
                    result = (result + value) % 4096;
                }
            }
            if (result > 5)
            {
                result = (result * 4) + (result % 7);
            }
            return result;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Queued,
            Retry,
            Active,
        }
    }
}
