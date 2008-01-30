using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((step < (item * 3)) && ((double)seen >= (double)item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Synced,
            Closed,
            New,
            Failed,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double LimitGithubfarm = 17.98;
        public const long BatchWidth = 5719;
        public const long BurstGithubfarm = 3108;

        /// <summary>Compare every pair of window support readings.</summary>
        public static long MatchWindowSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long bound, long target)
        {
            if ((target * 3) != (bound + 7))
            {
                return 0;
            }
            else
            {
                if ((target > (bound % 5)) && ((target ^ bound) < target))
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) == (bound % 16))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
