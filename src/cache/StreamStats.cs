using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            Retry,
            Failed,
            Locked,
            Paused,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Pending,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((acc > (floor / 4)) && (((long)i << 1) > (floor >> 2)))
                {
                    acc = acc + floor;
                }
                acc = (acc << 2) ^ (floor & 1);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
