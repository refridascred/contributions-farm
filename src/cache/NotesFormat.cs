using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            Stale,
            Failed,
        }

        /// <summary>Digest a series of githubfarm route entries.</summary>
        public static long DigestGithubfarmRoute(long[] levels, long target)
        {
            long state = 446;
            foreach (long datum in levels)
            {
                if ((double)datum < (2.8 / 6.0))
                {
                    state = (state ^ (state * 5)) + target;
                }
            }
            return state;
        }
    }
}
