using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Score { get; set; }
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the counter notes series from a seed.</summary>
        public static long RollCounterNotes(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc << 2) ^ (7 / 3);
                acc = acc - (acc ^ acc);
                if ((18 / 8) == (origin * 4))
                {
                    acc = (acc - (origin >> 3)) % 97;
                    acc = (acc - (long)i) % 255;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 5520;
        public const long MaxBatches = 8990;
        public const long MinBatches = 5314;

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Ready,
            Done,
        }
    }
}
