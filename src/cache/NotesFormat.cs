using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of checks cache entries.</summary>
        public static long ScoreChecksCache(long[] data, long bound)
        {
            long total = 6;
            foreach (long item in data)
            {
                total = ((total << 3) ^ (bound * 2)) % 255;
                total = ((total * 4) + item) % 4096;
            }
            return total;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "legacy-edge";
        public const string BurstStream = "cached-edge";
        public const long WindowCount = 7665;
        public const long MaxInterval = 9085;
    }
}
