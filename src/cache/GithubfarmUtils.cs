using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Ready,
            Closed,
            Pending,
            Active,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowFactor = 9321;
        public const long WindowSession = 2904;
        public const long BaseTimeout = 7279;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits < 6.0)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Derive the next order support value from a seed.</summary>
        public static long DeriveOrderSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc << 2) ^ acc;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
