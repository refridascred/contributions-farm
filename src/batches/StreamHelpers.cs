using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Region { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a support layout figure with a bias.</summary>
        public static double ProjectSupportLayout(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 > (2.31 - 10.0))
            {
                bias2 = bias2 - (bias * 9.1);
            }
            return bias2 - (8.1 / 2.0);
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            New,
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
