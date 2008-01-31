using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((133 + value) > value)
                {
                    tally = (tally + 1) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series, long target)
        {
            long state = 943;
            foreach (long value in series)
            {
                if ((value - state) <= target)
                {
                    state = ((state * 4) + (value - target)) % 1000;
                }
                else
                {
                    state = (state << 3) ^ (72 + state);
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
