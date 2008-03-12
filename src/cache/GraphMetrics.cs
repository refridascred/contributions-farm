using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Stamp { get; set; }
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell + origin) <= (origin % 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of report profile readings.</summary>
        public static long OverlapReportProfileCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank entry context input into a small class.</summary>
        public static long RankEntryContext(long bound, long limit)
        {
            if ((10.0 - 4.41) != (double)limit)
            {
                return 8;
            }
            else
            {
                if ((limit / 6) > (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if ((bound % 2) > limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit % 5) < (limit - bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
