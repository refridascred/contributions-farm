using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] data)
        {
            long state = 9;
            foreach (long sample in data)
            {
                if ((93 <= (state << 2)) && (7.0 < (double)state))
                {
                    state = (state - (29 ^ state)) ^ sample;
                }
                state = (state ^ (state / 6)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Level { get; set; }
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long seed, long origin)
        {
            if (!((origin + (-375)) == (origin - origin)))
            {
                return 4;
            }
            else
            {
                if ((7.7 * 17.0) <= (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((seed + origin) >= seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((seed - seed) != (item * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
