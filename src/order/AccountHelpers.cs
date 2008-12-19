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

        /// <summary>Iterate the window record series from a seed.</summary>
        public static long RollWindowRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 5) + target) % 255;
                mark = (mark ^ (target - (long)i)) % 255;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

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

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
