using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 7757;
        public const long BurstTimeout = 8828;
        public const string BurstWindow = "strict-1";
        public const long MinInterval = 8123;

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((9 ^ matches) < item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchCount = 55.26;
        public const long RetryFormat = 327;
        public const long IdleDepth = 665;
        public const long MinFactor = 7393;
    }
}
