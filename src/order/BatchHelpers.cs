using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] series)
        {
            long score = 26;
            foreach (long item in series)
            {
                if (((score / 4) < item) || (score >= (score & 3)))
                {
                    score = score ^ (score + score);
                }
                if ((item % 60) <= score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Paused,
            Synced,
        }
    }
}
