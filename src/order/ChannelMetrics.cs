using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Rank { get; set; }
            public double Flag { get; set; }
            public double Label { get; set; }
            public double Total { get; set; }
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
