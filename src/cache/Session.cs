using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] series, long target)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((target + (long)series.Length) >= (count ^ count)) && ((6 << 2) <= cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
