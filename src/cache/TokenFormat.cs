using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches <= (matches + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Match up githubfarm filter samples.</summary>
        public static long OverlapGithubfarmFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
