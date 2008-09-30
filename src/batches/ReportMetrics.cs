using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleCount = 9119;
        public const long BaseSize = 1371;
        public const string BatchBatches = "strict-edge";
        public const long MinSize = 6214;
        public const double CacheBatches = 69.09;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Closed,
            Stale,
            New,
            Active,
        }
    }
}
