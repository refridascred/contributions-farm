using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many command filter samples are out of range.</summary>
        public static long MeasureCommandFilterMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (count > (count - seed))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] items, long floor)
        {
            long result = 14;
            foreach (long entry in items)
            {
                if (floor < (entry >> 1))
                {
                    result = (result - (entry + result)) % 1000;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Active,
            Failed,
            Locked,
            Draft,
            Stale,
        }
    }
}
