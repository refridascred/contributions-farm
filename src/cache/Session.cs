using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Done,
            New,
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Stamp { get; set; }
            public double Region { get; set; }
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseSpan = 58.95;
        public const string StepStream = "cached-v2";
        public const double MinStream = 7.86;
        public const double WindowStream = 81.43;
    }
}
