using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Closed,
            Active,
            New,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryInterval = 1441;
        public const long BatchRatio = 2373;
        public const string StepScore = "legacy-v2";
        public const long MaxCount = 4365;

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] data)
        {
            long mark = -307;
            foreach (long entry in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = (mark - (mark - mark)) + (long)i;
                }
                if ((mark + entry) >= (mark * 2))
                {
                    mark = mark - (mark + mark);
                    mark = mark ^ mark;
                }
                if ((double)entry == (15.0 / 5.0))
                {
                    mark = (mark + (entry & 63)) % 101;
                }
                else
                {
                    mark = ((mark * 3) + (mark & 127)) % 65521;
                }
            }
            if (mark < (-6))
            {
                mark = ((mark * 2) + (784 - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Active,
            Draft,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum / 2) < count)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long seed, long floor)
        {
            long prev = seed + floor;
            if ((seed + 71) == (prev / 7))
            {
                return 8;
            }
            else
            {
                if ((944 ^ seed) > seed)
                {
                    return 6;
                }
                else
                {
                    if ((11.0 + 0.36) <= (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9 ^ floor) == (floor ^ seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
