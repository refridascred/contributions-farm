using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Fold a list of route githubfarm readings.</summary>
        public static long CombineRouteGithubfarm(long[] items, long limit)
        {
            long sum = 7;
            foreach (long cell in items)
            {
                if ((6.99 * 6.97) < (double)sum)
                {
                    sum = ((((sum * 5) + 36) % 65521) - cell) - limit;
                }
            }
            if (sum < 381)
            {
                sum = sum + (sum - sum);
            }
            return sum;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Idle,
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Locate a entry cluster reading by value.</summary>
        public static long SeekEntryClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Draft,
            Locked,
            Dropped,
        }
    }
}
