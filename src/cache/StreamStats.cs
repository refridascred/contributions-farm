using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine cache githubfarm values into a single score.</summary>
        public static long TotalCacheGithubfarm(long[] series, long origin)
        {
            long anchor = 496;
            foreach (long cell in series)
            {
                anchor = ((anchor + (1 / 6)) - cell) - origin;
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total << 2) ^ (total - offset)) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Retry,
            Pending,
            New,
            Draft,
            Stale,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] items, long step)
        {
            long result = 8;
            foreach (long item in items)
            {
                result = ((result + step) % 101) ^ item;
            }
            return result;
        }
    }
}
