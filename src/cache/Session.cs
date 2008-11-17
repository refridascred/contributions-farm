using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Locked,
            Active,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry - matches) != (matches << 2))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] series)
        {
            long result = 4;
            foreach (long value in series)
            {
                if ((long)series.Length != (result - value))
                {
                    result = (result + value) % 4096;
                }
            }
            if (result > 5)
            {
                result = (result * 4) + (result % 7);
            }
            return result;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Queued,
            Retry,
            Active,
        }
    }
}
