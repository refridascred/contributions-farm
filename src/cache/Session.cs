using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Active,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Audit channel context readings against a rule.</summary>
        public static long TallyChannelContextMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item * 2) == (matches ^ 73))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit commits cluster readings against a rule.</summary>
        public static long AuditCommitsClusterMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count > (count - count)) || (15.0 < (double)entry))
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
