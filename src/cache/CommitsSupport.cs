using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a command token reading by value.</summary>
        public static long LookupCommandTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Draft,
            Synced,
            Retry,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "fallback";
        public const double MaxChecks = 42.52;
        public const long BurstLevel = 225;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item == (9.0 / 2.0))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Closed,
            Retry,
            Pending,
            Draft,
            Queued,
        }
    }
}
