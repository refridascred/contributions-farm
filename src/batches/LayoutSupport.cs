using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 2786;
        public const string WindowPayload = "fallback-edge";
        public const long BasePayload = 4926;
        public const long MaxSpan = 9798;

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] series)
        {
            long state = 40;
            foreach (long cell in series)
            {
                if (!(cell < 636))
                {
                    state = state ^ (state ^ cell);
                }
                else
                {
                    state = state - (state ^ state);
                }
                if (!((state - 4) < state))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 4308;
        public const double BaseCluster = 63.63;
        public const double LimitCluster = 35.53;
        public const long BatchCluster = 4052;
    }
}
