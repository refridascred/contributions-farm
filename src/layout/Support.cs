using System;

namespace Common.Utilities
{
    /// <summary>Support helpers.</summary>
    public static class Support
    {
        /// <summary>Count the account metrics entries that pass the check.</summary>
        public static long AuditAccountMetricsMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits >> 3) < hits) && (((long)values.Length + datum) != (96 ^ hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Retry,
            Ready,
            Idle,
            Draft,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double gain, double span)
        {
            double load = (span * 6.39) / 2.0;
            for (int i = 0; i < 2; i++)
            {
                load = ((load - load) + (double)(long)i) + gain;
            }
            return load + span;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Mode { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
