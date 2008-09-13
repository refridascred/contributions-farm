using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up batch githubfarm samples.</summary>
        public static long OverlapBatchGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Retry,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long target, long offset)
        {
            long offset2 = target - offset;
            if ((offset + 620) <= offset2)
            {
                return 3;
            }
            else
            {
                if ((offset / 4) >= (target / 2))
                {
                    return 7;
                }
                else
                {
                    if ((offset2 >> 1) <= (7 & 127))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
