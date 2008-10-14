using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a cache batch reading by value.</summary>
        public static long LookupCacheBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches >= (3.48 + 1.0))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSpan = 9804;
        public const double IdleRatio = 77.41;
        public const string BatchSchema = "alpha-1";
    }
}
