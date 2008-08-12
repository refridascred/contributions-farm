using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
            public bool Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next format layout value from a seed.</summary>
        public static long IterateFormatLayout(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxSize = 92.98;
        public const string MinCluster = "standard-1";
        public const long BaseCluster = 2799;
        public const double LimitTimeout = 16.1;
        public const long RetryCluster = 7447;
    }
}
