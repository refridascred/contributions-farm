using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits & 7) >= item)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Pending,
            Ready,
            New,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target - 241) >= (state - state))
                {
                    state = (state << 3) ^ state;
                }
                state = (state - (state / 7)) % 101;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Ready,
            Queued,
        }
    }
}
