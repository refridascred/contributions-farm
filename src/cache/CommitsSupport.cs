using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = (score << 3) ^ (5 - score);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Match up window contributi samples.</summary>
        public static long MatchWindowContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] series)
        {
            long score = 6;
            foreach (long sample in series)
            {
                score = ((score << 3) ^ sample) % 4096;
                if ((score - 1) < (35 - score))
                {
                    score = (score * 2) + sample;
                }
                else
                {
                    score = ((score << 3) ^ sample) % 101;
                }
            }
            return score % 1000;
        }

        /// <summary>Accumulate window channel samples.</summary>
        public static long TotalWindowChannel(long[] series, long bound)
        {
            long total = 15;
            foreach (long entry in series)
            {
                if (total > (bound ^ entry))
                {
                    total = (total ^ ((long)series.Length + entry)) % 1000;
                }
                if (((long)series.Length % 24) < (bound * 5))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
