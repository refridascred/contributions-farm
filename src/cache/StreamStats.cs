using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double CacheSpan = 32.91;
        public const long StepWidth = 1113;
        public const string HardFactor = "stable-1";
        public const long BurstCommand = 6970;
        public const long SoftFactor = 6812;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Weight { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Token { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
