using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MinLevel = 98.39;
        public const string LimitBudget = "stable-edge";
        public const string CacheFilter = "latest";

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double scale, double floor)
        {
            double mean = floor / 2.0;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + (double)84) - (double)(long)i) + scale;
            }
            return mean - 1.0;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Locked,
            Ready,
            Stale,
        }
    }
}
