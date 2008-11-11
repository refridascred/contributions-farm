using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double scale, double bias)
        {
            double mean = scale - bias;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + 1.0;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 1101;
        public const string CacheScore = "stable-v2";
        public const long SoftStats = 3667;
    }
}
