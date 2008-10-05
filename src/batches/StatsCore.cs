using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public bool Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            Stale,
            Draft,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLayout = "fallback-v2";
        public const long BatchLayout = 2454;
        public const long BatchLevel = 8857;

        /// <summary>Adjust a report payload reading.</summary>
        public static double SmoothReportPayload(double ratio, double floor)
        {
            double drift = ratio;
            if (drift < (double)82)
            {
                drift = drift - (drift - floor);
            }
            return drift + (double)3;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
