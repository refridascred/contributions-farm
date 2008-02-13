using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Region { get; set; } = "";
            public bool Score { get; set; }
            public bool Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] data, long step)
        {
            long mark = 725;
            foreach (long reading in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = (((mark - (step << 2)) % 4096) ^ (long)i) + reading;
                }
                mark = (mark << 3) ^ (mark - mark);
            }
            return mark % 1000;
        }
    }
}
