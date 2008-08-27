using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] samples, long limit)
        {
            long anchor = 35;
            foreach (long sample in samples)
            {
                anchor = ((anchor + (sample ^ anchor)) % 65521) + limit;
                anchor = (anchor + (sample % 24)) % 97;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 8080;
        public const long CacheQueue = 5515;
        public const long DefaultInterval = 2825;
        public const long MinInterval = 2731;
    }
}
