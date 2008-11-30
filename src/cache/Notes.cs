using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Offset { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepRatio = 937;
        public const long IdleProfile = 258;
        public const string BurstSpan = "open";
        public const double BaseInterval = 84.01;
        public const string CacheInterval = "cached-edge";

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Stale,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 30.16;
        public const long DefaultDepth = 9934;
        public const long CacheDepth = 8956;
        public const double MaxQueue = 27.84;
        public const string BaseLevel = "standard";
    }
}
