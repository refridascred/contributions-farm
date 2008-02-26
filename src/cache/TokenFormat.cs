using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((seed * 4) < (seed + entry)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Draft,
            Active,
            Stale,
            New,
            Paused,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchFormat = "alpha-1";
        public const long BaseFormat = 8251;
        public const string MaxFormat = "strict-1";
    }
}
