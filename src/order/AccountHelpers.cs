using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item >= 547)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 1528;
        public const long WindowLayout = 1864;
        public const string CacheLayout = "open-1";
        public const string WindowDepth = "legacy-1";

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Stamp { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((tally * 3) < (tally * 4)) && ((value + (-810)) <= (tally & 15)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > 7.0)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 - (double)857;
            }
            return bias2 - (scale / 7.0);
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Retry,
            Queued,
            Idle,
        }
    }
}
