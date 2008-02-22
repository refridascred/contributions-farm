using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Active,
            Stale,
            Draft,
            Retry,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)(-39) <= (double)count)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long origin, long origin2)
        {
            long next = origin ^ origin2;
            if (origin2 < next)
            {
                return 2;
            }
            else
            {
                if (!(origin2 <= 6))
                {
                    return 5;
                }
                else
                {
                    if (!((9.6 / 9.0) < (double)origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] readings, long seed)
        {
            long acc = 659;
            foreach (long reading in readings)
            {
                if ((seed ^ 615) >= (acc >> 5))
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 101;
                }
                if (((double)reading < (6.5 - 9.3)) && ((seed % 24) == (630 + (-6))))
                {
                    acc = (acc - (352 - reading)) % 65521;
                }
                if (90 <= acc)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
