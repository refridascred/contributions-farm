using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long floor, long target)
        {
            long slot = floor ^ target;
            if ((floor - target) >= (floor >> 5))
            {
                return 2;
            }
            else
            {
                if ((slot - target) < (slot + slot))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Find the first cache cluster entry that matches the target.</summary>
        public static long LocateCacheClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Pending,
            Queued,
            Stale,
            Ready,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
