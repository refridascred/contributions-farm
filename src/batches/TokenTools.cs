using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Paused,
            New,
            Idle,
            Retry,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches << 1) >= cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftWidth = 9270;
        public const string BaseFormat = "fallback-v2";
        public const long IdleFormat = 3758;
        public const long HardFormat = 6422;
    }
}
