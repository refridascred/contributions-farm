using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 3674;
        public const string MaxDepth = "alpha-1";
        public const long IdleReport = 5178;
        public const long DefaultWidth = 1926;

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Total { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "standard-v2";
        public const long WindowScore = 9084;
        public const long SoftChannel = 5481;
        public const string MinRatio = "local-v2";

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Closed,
            Stale,
            Idle,
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
