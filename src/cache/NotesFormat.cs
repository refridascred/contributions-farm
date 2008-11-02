using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((cell - cell) > 72) && ((origin ^ cell) > cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
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
