using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long target, long limit)
        {
            long next = target - limit;
            if ((3.0 - 7.01) >= (double)limit)
            {
                return 2;
            }
            else
            {
                if (target < (2 >> 2))
                {
                    return 6;
                }
                else
                {
                    if (!((18.0 * 7.66) > (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target + next) > target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 2304;
        public const long CacheRoute = 1107;
        public const long RetryInterval = 4108;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((reading * 2) == (reading >> 2)) || ((2.8 - 9.1) <= (double)reading))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
