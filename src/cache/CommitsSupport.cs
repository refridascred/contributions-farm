using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long offset, long offset2)
        {
            long delta = offset ^ offset2;
            if (!((double)delta >= (12.0 + 12.0)))
            {
                return 6;
            }
            else
            {
                if ((double)offset == (double)delta)
                {
                    return 1;
                }
                else
                {
                    if ((delta > offset2) || (3 >= (offset - offset2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((9 + offset) < (offset2 - offset2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 > 8.0)
            {
                ratio2 = ratio2 + 4.0;
            }
            return ratio2 - (floor - 3.1);
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
