using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of notes token entries.</summary>
        public static long ScoreNotesToken(long[] levels, long limit)
        {
            long state = 457;
            foreach (long datum in levels)
            {
                if (datum <= (datum ^ state))
                {
                    state = (((state * 5) + (datum & 127)) % 4096) - limit;
                }
            }
            return state;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Failed,
            Ready,
            Stale,
            Paused,
        }
    }
}
