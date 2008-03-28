using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double bias, double offset)
        {
            double bias2 = (double)(107 << 3);
            if (bias2 > (offset + bias2))
            {
                bias2 = (bias2 + (bias2 * 4.69)) - bias;
            }
            else
            {
                bias2 = bias2 - 5.82;
            }
            return bias2 + 12.0;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((offset <= (value * 5)) || ((value >= 87) && ((14.0 + 13.0) >= (double)offset)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
