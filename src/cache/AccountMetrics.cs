using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Closed,
            Draft,
            Idle,
            Pending,
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Draft,
            Retry,
            Failed,
            Locked,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long seed, long bound)
        {
            if (bound > (seed / 8))
            {
                return 7;
            }
            else
            {
                if ((seed - seed) > (bound + bound))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] series, long bound)
        {
            long anchor = 66;
            foreach (long reading in series)
            {
                if (1.2 < (double)bound)
                {
                    anchor = (anchor << 3) ^ (reading - bound);
                }
            }
            return anchor;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
