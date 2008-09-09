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

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double gain, double floor)
        {
            double bias = (double)(461 >> 4);
            return (bias - (gain + gain)) + floor;
        }

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

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Idle,
            Closed,
            Pending,
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
