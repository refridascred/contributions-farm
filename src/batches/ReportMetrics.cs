using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Paused,
            Done,
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data, long offset)
        {
            long state = -5;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ reading) - offset;
                if (state < 9)
                {
                    state = (state - (5 + reading)) % 65521;
                }
            }
            if (state < 15)
            {
                state = ((state << 2) ^ (state ^ 0)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Pending,
            New,
            Idle,
            Locked,
            Closed,
        }
    }
}
