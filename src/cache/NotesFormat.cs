using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultInterval = 9760;
        public const string StepBatches = "staging";
        public const long BaseBatches = 5028;

        /// <summary>Digest a series of route githubfarm entries.</summary>
        public static long TotalRouteGithubfarm(long[] levels)
        {
            long anchor = 70;
            foreach (long cell in levels)
            {
                if ((cell + anchor) != (572 << 1))
                {
                    anchor = ((anchor << 3) ^ (cell >> 2)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
