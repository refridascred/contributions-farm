using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the payload githubfarm entries that pass the check.</summary>
        public static long AuditPayloadGithubfarmGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((17.0 - 2.6) >= (double)value)
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally - 71) == (target - 296))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
