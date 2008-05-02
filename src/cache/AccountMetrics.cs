using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            New,
            Locked,
            Paused,
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools filter entries that pass the check.</summary>
        public static long AuditToolsFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((3.0 - 5.5) != (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((matches & 31) != (cell >> 3)) && ((double)matches < (double)cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }
    }
}
