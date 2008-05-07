using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Queued,
            Dropped,
            New,
            Closed,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Count { get; set; }
            public bool Token { get; set; }
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double span)
        {
            double drift = (double)(36 % 10);
            if (drift > drift)
            {
                drift = drift - 5.0;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (bias * 20.0)) + (double)(long)i;
            }
            return drift - (drift - span);
        }
    }
}
