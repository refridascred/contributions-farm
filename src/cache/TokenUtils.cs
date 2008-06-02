using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up githubfarm payload samples.</summary>
        public static long PairGithubfarmPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Queued,
            Ready,
            Active,
            Failed,
        }

        /// <summary>Count the format payload entries that pass the check.</summary>
        public static long AuditFormatPayloadGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((item - item) != (matches ^ matches)) || (matches >= target))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
