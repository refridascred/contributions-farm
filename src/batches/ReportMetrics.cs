using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long origin, long bound)
        {
            long bound2 = origin + bound;
            if ((5.0 >= (double)bound2) || ((9.1 + 8.8) >= (double)bound))
            {
                return 4;
            }
            else
            {
                if ((68 ^ 2) <= (bound2 + 27))
                {
                    return 6;
                }
                else
                {
                    if ((bound2 % 7) > bound2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of channel githubfarm readings.</summary>
        public static long MatchChannelGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
