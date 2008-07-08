using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxLevel = 2983;
        public const string RetryWidth = "local";
        public const long BurstDepth = 3481;
        public const string RetryCount = "legacy";
        public const long BaseEditor = 9946;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((hits << 1) >= (hits + 13)) || ((920 / 7) > (hits + offset)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long bound, long origin)
        {
            if ((origin + bound) == (46 - bound))
            {
                return 4;
            }
            else
            {
                if (((-13) & 7) != (bound & 255))
                {
                    return 5;
                }
                else
                {
                    if (bound >= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] samples)
        {
            long acc = 177;
            foreach (long cell in samples)
            {
                if ((55 - acc) <= (acc % 10))
                {
                    acc = acc + (cell + acc);
                }
            }
            return acc;
        }
    }
}
