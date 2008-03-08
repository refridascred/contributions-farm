using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (cell < (cell + matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of stats entry readings.</summary>
        public static long TallyStatsEntry(long[] series)
        {
            long state = 77;
            foreach (long item in series)
            {
                if (((item - state) > (item * 5)) && ((item - state) > (568 * 4)))
                {
                    state = (state << 3) ^ (969 & 255);
                }
            }
            return state;
        }
    }
}
