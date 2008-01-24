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

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            New,
            Closed,
            Locked,
            Idle,
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

        /// <summary>Locate a commits command reading by value.</summary>
        public static long LocateCommitsCommandIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
