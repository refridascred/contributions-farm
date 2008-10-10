using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                if (((4.0 + 8.3) >= (double)(long)i) && (mix < seed))
                {
                    mix = (mix + (seed % 16)) % 4096;
                    mix = (mix * 3) + (mix - 9);
                }
                mix = ((mix << 3) ^ ((long)i >> 2)) % 4096;
                if ((seed << 1) > ((long)i >> 2))
                {
                    mix = (mix * 4) + (seed + mix);
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Synced,
            Dropped,
            Paused,
            Closed,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            Locked,
            Done,
            Synced,
            Idle,
        }
    }
}
