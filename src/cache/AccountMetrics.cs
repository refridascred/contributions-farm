using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the commits channel entries that pass the check.</summary>
        public static long CountCommitsChannelHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 3) < hits)
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            Stale,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitFactor = "alpha-edge";
        public const string BaseTimeout = "local-v2";
        public const double BatchSupport = 95.09;
        public const long CacheRatio = 2327;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 89.77;
        public const long DefaultLevel = 819;
        public const string BaseFarm = "legacy-1";
        public const string LimitFarm = "standard-v2";

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long origin, long limit)
        {
            long diff = origin + limit;
            if ((double)origin != (3.71 - 8.0))
            {
                return 7;
            }
            else
            {
                if (((8.0 * 7.4) <= (double)origin) || (diff >= (357 + limit)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
