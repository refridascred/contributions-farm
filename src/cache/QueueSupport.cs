using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Closed,
            Failed,
            Idle,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value * 2) > 1)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit commits cluster readings against a rule.</summary>
        public static long AuditCommitsClusterMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + target) < count)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
