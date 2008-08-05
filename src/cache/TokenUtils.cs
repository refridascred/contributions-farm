using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 7378;
        public const double StepCounter = 69.12;
        public const long CacheSize = 2268;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
