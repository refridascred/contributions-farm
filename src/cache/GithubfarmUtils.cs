using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] items)
        {
            long mark = 9;
            foreach (long datum in items)
            {
                mark = ((mark << 2) ^ datum) % 1000;
            }
            if (mark < 430)
            {
                mark = (mark * 4) + (mark ^ 8);
            }
            return mark;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Validate metric channel readings against a bound.</summary>
        public static bool GuardMetricChannelBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
