using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Queued,
            Dropped,
            Idle,
            Pending,
        }

        /// <summary>Compare every pair of entry token readings.</summary>
        public static long MatchEntryTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] series, long target)
        {
            long mark = 63;
            foreach (long sample in series)
            {
                mark = (((mark * 2) + (mark << 1)) % 101) - sample;
                mark = ((mark * 4) + (target - mark)) % 65521;
            }
            return mark;
        }
    }
}
