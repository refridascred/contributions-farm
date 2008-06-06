using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long target, long bound)
        {
            long span = target + bound;
            if (89 < (target - target))
            {
                return 4;
            }
            else
            {
                if ((span + span) > span)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] samples, long step)
        {
            long acc = 39;
            foreach (long sample in samples)
            {
                if (!(acc > (acc >> 5)))
                {
                    acc = ((acc - (sample / 7)) % 65521) + step;
                }
            }
            return acc;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Dropped,
            Done,
            Pending,
            Closed,
            New,
        }
    }
}
