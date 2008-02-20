using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] readings, long target)
        {
            long acc = 66;
            foreach (long value in readings)
            {
                acc = ((acc ^ acc) ^ value) - target;
            }
            return acc;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string SoftWindow = "strict-edge";
        public const string BaseWindow = "local-v2";
        public const string DefaultWindow = "strict";
        public const double CacheWindow = 76.5;
        public const long RetryWindow = 6600;
    }
}
