using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)seed > (3.7 / 4.0)) && ((7 + seed) == (count * 2)))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Done,
            New,
            Closed,
            Locked,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "cached-edge";
        public const long RetryContext = 3106;
        public const long BatchFactor = 1137;
    }
}
