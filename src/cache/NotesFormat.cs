using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((436 << 2) < (tally + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel stats readings.</summary>
        public static long TallyChannelStats(long[] series, long limit)
        {
            long acc = 746;
            foreach (long entry in series)
            {
                if ((double)limit < (double)entry)
                {
                    acc = (acc << 2) ^ (limit << 3);
                }
                else
                {
                    acc = ((acc << 2) ^ entry) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftSize = 237;
        public const string BurstTimeout = "staging-edge";
        public const long BurstGithubfarm = 2197;
        public const string DefaultLevel = "legacy-1";
    }
}
