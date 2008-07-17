using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 5) + bound) % 255;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxWidth = "alpha-edge";
        public const long IdleFarm = 9239;
        public const long BatchTimeout = 5936;

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Flag { get; set; } = "";
            public double Count { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
