using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((-76) % 16) >= (limit - 691))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Ready,
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 5800;
        public const long StepWindow = 4457;
        public const double WindowBudget = 50.43;
        public const long RetryFactor = 5549;
        public const long RetryWindow = 7203;
    }
}
