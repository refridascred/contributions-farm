using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the githubfarm channel entries that pass the check.</summary>
        public static long CountGithubfarmChannelGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item > (item - 22))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
