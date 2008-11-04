using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 2431;
        public const double LimitCommits = 60.18;
        public const double BatchCommits = 33.7;

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitFactor = 7262;
        public const long DefaultCache = 9489;
        public const long SoftBudget = 8096;
        public const long BatchCache = 4571;

        /// <summary>Count already profile pairs that satisfy a relation.</summary>
        public static long MatchAlreadyProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
