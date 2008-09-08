using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate githubfarm command readings against a bound.</summary>
        public static bool VerifyGithubfarmCommandRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Dropped,
            Stale,
            Queued,
            Synced,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long limit, long seed)
        {
            if (((8 % 64) != (limit ^ 81)) || ((86 + 65) <= (seed * 4)))
            {
                return 3;
            }
            else
            {
                if (((seed << 2) < (limit - seed)) && (limit > (limit * 5)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
