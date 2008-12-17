using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Locked,
            Paused,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchRatio = "legacy-v2";
        public const long BatchWindow = 2033;
        public const long DefaultCount = 9105;
        public const string WindowLevel = "staging";

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 7615;
        public const double MinAlready = 21.71;
        public const long BaseCount = 5093;
        public const string StepAlready = "open";

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
