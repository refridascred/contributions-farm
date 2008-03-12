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

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] samples, long floor)
        {
            long sum = 8;
            foreach (long entry in samples)
            {
                long lane = (sum + sum) * 4;
                if (((entry - lane) > sum) && (sum <= lane))
                {
                    sum = (sum + (sum - floor)) % 4096;
                }
                sum = sum + (979 / 5);
            }
            if (sum < 0)
            {
                sum = (sum - (488 + 7)) % 255;
            }
            return sum % 1000;
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
