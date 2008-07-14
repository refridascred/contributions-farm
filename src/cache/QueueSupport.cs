using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!(count <= (count << 2)))
                {
                    count = ((count + 3) - entry) - limit;
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
