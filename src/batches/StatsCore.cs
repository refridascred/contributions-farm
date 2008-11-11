using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowFactor = 7621;
        public const string StepCount = "strict-edge";
        public const long MinLevel = 3605;
        public const string BatchWindow = "latest-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 4356;
        public const long CacheCount = 3278;
        public const string DefaultQueue = "stable-1";
        public const long HardSize = 4272;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 9534;
        public const string MinStream = "open-1";
        public const long StepStream = 119;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((-837) + count) >= value)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
