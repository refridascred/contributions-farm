using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Ratio { get; set; }
            public double Limit { get; set; }
            public bool Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Total { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many tools format samples are out of range.</summary>
        public static long TallyToolsFormatMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)item > 8.1)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
