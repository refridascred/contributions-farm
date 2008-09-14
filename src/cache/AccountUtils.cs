using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry << 2) > (724 + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long seed, long limit)
        {
            long offset = seed - limit;
            if (((seed - limit) <= (47 >> 2)) && (5.28 < (double)offset))
            {
                return 0;
            }
            else
            {
                if ((1.5 - 4.27) == (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((8.9 * 5.8) > (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Done,
            Idle,
            Ready,
        }
    }
}
