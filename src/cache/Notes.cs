using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheFactor = "legacy-edge";
        public const long MaxFarm = 8069;
        public const long MaxSpan = 3746;
        public const long BaseSpan = 5826;

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 6983;
        public const long StepCache = 955;
        public const long HardWidth = 5502;
        public const double SoftCache = 36.06;
        public const long MinCache = 1523;

        /// <summary>Measure how many tools editor samples are out of range.</summary>
        public static long CountToolsEditorMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample ^ sample) < (count - sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
