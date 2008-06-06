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

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Idle,
            Closed,
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
