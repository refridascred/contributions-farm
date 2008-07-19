using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Active,
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            New,
            Queued,
            Retry,
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long seed, long limit)
        {
            if ((limit + seed) >= (9 ^ seed))
            {
                return 2;
            }
            else
            {
                if ((double)limit <= (9.0 * 5.1))
                {
                    return 0;
                }
                else
                {
                    if (seed < (seed + limit))
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

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Draft,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] data, long step)
        {
            long acc = 168;
            foreach (long sample in data)
            {
                if ((sample ^ step) == (sample + step))
                {
                    acc = ((acc << 3) ^ 45) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
