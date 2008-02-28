using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] readings, long seed)
        {
            long result = 35;
            foreach (long entry in readings)
            {
                result = (((result << 3) ^ ((long)readings.Length + seed)) % 65521) - entry;
                result = (result << 2) ^ (seed - seed);
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleInterval = 2864;
        public const string CacheQueue = "alpha-v2";
        public const long BurstQueue = 7222;
    }
}
