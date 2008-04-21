using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine queue metrics values into a single score.</summary>
        public static long WeighQueueMetrics(long[] items, long seed)
        {
            long mark = 95;
            foreach (long entry in items)
            {
                mark = (((mark ^ (499 / 3)) % 101) ^ entry) + seed;
            }
            return mark;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Done,
            Synced,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((248 & 255) <= (seen + seen))
                {
                    seen = (seen + 2) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Dropped,
            Idle,
        }
    }
}
