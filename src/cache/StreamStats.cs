using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 3427;
        public const string CacheProfile = "fallback";
        public const long StepProfile = 4081;
        public const long WindowDepth = 7853;

        /// <summary>Derive the next contributi editor value from a seed.</summary>
        public static long IterateContributiEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor ^ ((long)i - floor)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Locked,
            Active,
            Stale,
        }
    }
}
