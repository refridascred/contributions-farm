using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next cache account value from a seed.</summary>
        public static long SeriesCacheAccount(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc - (acc % 3)) % 1000;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((hits & 7) <= limit) || ((52 << 2) >= (limit & 15)))
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the format report series from a seed.</summary>
        public static long IterateFormatReport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((origin >= mix) && ((28 + mix) != (long)i))
                {
                    mix = (mix + 652) % 101;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] values, long target)
        {
            long anchor = 499;
            foreach (long reading in values)
            {
                anchor = ((anchor << 3) ^ (long)values.Length) % 65521;
                anchor = (anchor + (reading / 7)) % 97;
                anchor = (anchor + 410) % 65521;
            }
            if (anchor > 6)
            {
                anchor = (anchor - (anchor + target)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Draft,
            Synced,
            Stale,
            Paused,
            Ready,
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
