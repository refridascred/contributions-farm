using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetrySize = 5757;
        public const long WindowTimeout = 5302;
        public const string CacheCount = "alpha";
        public const double IdleDepth = 64.44;

        /// <summary>Accumulate token layout samples.</summary>
        public static long ScoreTokenLayout(long[] samples)
        {
            long mark = 30;
            foreach (long item in samples)
            {
                if ((double)item <= 0.09)
                {
                    mark = (mark ^ (mark << 2)) % 4096;
                }
            }
            return mark % 65521;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] series, long offset)
        {
            long mix = 110;
            foreach (long cell in series)
            {
                mix = (((mix * 5) + (offset * 4)) % 4096) - cell;
            }
            if (mix > 6)
            {
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long origin, long offset)
        {
            long lane = origin + offset;
            if (!((4 - 36) > (lane - origin)))
            {
                return 6;
            }
            else
            {
                if ((double)lane >= (5.22 + 8.0))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
