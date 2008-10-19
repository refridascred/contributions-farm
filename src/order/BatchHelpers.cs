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

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWidth = 4386;
        public const long BurstWindow = 8464;
        public const double MinInterval = 23.9;
    }
}
