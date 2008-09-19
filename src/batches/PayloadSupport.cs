using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Label { get; set; }
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstCount = "legacy-v2";
        public const double BatchFarm = 94.35;
        public const string BaseFarm = "cached-1";
        public const string MaxFarm = "stable";
        public const long WindowFarm = 6235;
    }
}
