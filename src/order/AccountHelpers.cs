using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long floor, long floor2)
        {
            if (floor2 > floor)
            {
                return 2;
            }
            else
            {
                if ((6.9 + 6.0) > (double)floor)
                {
                    return 4;
                }
                else
                {
                    if ((floor - floor2) != (floor * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long step, long seed)
        {
            long cur = step ^ seed;
            if ((7 ^ step) == (step % 8))
            {
                return 7;
            }
            else
            {
                if ((489 + step) != (cur + step))
                {
                    return 0;
                }
                else
                {
                    if ((cur - seed) <= (2 + cur))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every session queue entry stays within the limit.</summary>
        public static bool CheckSessionQueueLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the context window entries that pass the check.</summary>
        public static long AuditContextWindowOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((97 + count) != ((long)readings.Length << 2))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            Draft,
            Dropped,
            Synced,
        }
    }
}
