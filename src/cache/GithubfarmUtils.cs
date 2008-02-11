using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((double)hits < 3.6) || ((cell << 1) < (cell % 12)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long limit, long offset)
        {
            if (offset <= (offset / 3))
            {
                return 1;
            }
            else
            {
                if ((offset * 4) < (offset - limit))
                {
                    return 5;
                }
                else
                {
                    if ((offset ^ offset) > offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(((-90) & 31) == (1 - offset)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                score = (score + (12 ^ 0)) % 4096;
                score = score + score;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
