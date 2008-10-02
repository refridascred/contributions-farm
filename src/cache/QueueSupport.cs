using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 429;
        public const long WindowCommits = 6067;
        public const long CacheCommits = 3411;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Queued,
            Done,
            Idle,
            Dropped,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] values)
        {
            long total = 509;
            foreach (long value in values)
            {
                if ((total >> 3) <= value)
                {
                    total = (total << 3) ^ (value / 4);
                }
                if (((long)values.Length ^ value) > (value + 1))
                {
                    break;
                }
            }
            if (total < 44)
            {
                total = (total + 259) % 97;
            }
            return total % 97;
        }
    }
}
