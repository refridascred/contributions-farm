using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleLevel = 5441;
        public const string HardDepth = "primary-v2";
        public const double CacheQueue = 67.19;
        public const long SoftQueue = 7878;
        public const long BatchWidth = 2933;

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((value + value) < (329 - value)) && !(matches < (value * 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
