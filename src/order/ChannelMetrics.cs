using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] values)
        {
            long anchor = -770;
            foreach (long datum in values)
            {
                anchor = anchor ^ (anchor & 255);
                if ((double)datum < 4.4)
                {
                    anchor = (anchor + (anchor - 443)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
            public double Count { get; set; }
        }
    }
}
