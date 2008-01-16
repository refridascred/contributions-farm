using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long floor, long limit)
        {
            long diff = floor - limit;
            if ((floor + 6) < (floor + floor))
            {
                return 8;
            }
            else
            {
                if ((diff + limit) < 923)
                {
                    return 5;
                }
                else
                {
                    if ((diff - 988) < (floor + 0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (216 <= (cell % 8))
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Closed,
            Synced,
            Paused,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 750;
        public const double BaseSize = 41.2;
        public const long RetryLevel = 2374;
        public const double RetryInterval = 52.27;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((datum + 0) >= seen) && (datum < (datum >> 5)))
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }
    }
}
