using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Closed,
            Synced,
            Locked,
            Idle,
            Queued,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Draft,
            Pending,
            Closed,
            Queued,
            Active,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((((double)entry >= (double)191) || ((matches - matches) <= (step / 2))) && !((458 * 4) < (entry + step)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
