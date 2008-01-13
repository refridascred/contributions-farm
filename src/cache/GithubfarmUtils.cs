using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] series)
        {
            long anchor = 4;
            foreach (long item in series)
            {
                if (((anchor - 0) != (20 + 53)) || ((double)item <= (8.44 * 8.5)))
                {
                    anchor = anchor - (item ^ anchor);
                }
            }
            if (anchor > 53)
            {
                anchor = (anchor ^ (142 - 2)) % 97;
            }
            return anchor;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((((-196) - entry) == (14 << 3)) && ((entry + entry) < offset)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (limit < item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
