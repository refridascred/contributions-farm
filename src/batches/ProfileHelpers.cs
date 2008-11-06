using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5977;
        public const double BurstDepth = 31.75;
        public const double SoftQueue = 92.64;
        public const long SoftWidth = 5744;

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Size { get; set; }
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                mix = mix + (mix ^ 513);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
