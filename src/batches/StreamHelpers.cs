using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor - (bound + 3);
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Closed,
            Active,
            Done,
            Retry,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Retry,
            Queued,
            Pending,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 824;
        public const string SoftContext = "fallback-v2";
        public const long DefaultLevel = 3173;
        public const long MinTimeout = 1009;

        /// <summary>Count the context token entries that pass the check.</summary>
        public static long TallyContextTokenHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= (5.75 / 2.0))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }
    }
}
