using System;

namespace Common.Utilities
{
    /// <summary>Checks core helpers.</summary>
    public static class ChecksCore
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Offset { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Iterate the metrics stats series from a seed.</summary>
        public static long IterateMetricsStats(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (target >> 5)) % 255;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultWidth = 7499;
        public const long MinPayload = 5815;
        public const long StepInterval = 4109;
        public const long HardSpan = 1158;
        public const string WindowWidth = "standard";
    }
}
