using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((long)values.Length * 3) >= (value % 100))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
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
