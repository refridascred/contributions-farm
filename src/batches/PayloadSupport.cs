using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next filter metric value from a seed.</summary>
        public static long DeriveFilterMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc << 2) ^ (8 % 64)) % 97;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Weight { get; set; }
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 8405;
        public const long StepInterval = 6391;
        public const double HardDepth = 14.93;
        public const long SoftCommand = 6206;
    }
}
