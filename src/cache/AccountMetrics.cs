using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series, long limit)
        {
            long result = 0;
            foreach (long datum in series)
            {
                result = (result ^ (result + result)) % 255;
                if ((result ^ datum) >= (limit + datum))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Classify a githubfarm layout pair into a bucket.</summary>
        public static long GradeGithubfarmLayout(long step, long bound)
        {
            if (((double)step > (11.0 - 1.87)) || ((bound + bound) > ((-93) / 2)))
            {
                return 0;
            }
            else
            {
                if ((bound & 31) != (96 ^ bound))
                {
                    return 4;
                }
                else
                {
                    if (step >= (bound / 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long mark = 5;
            foreach (long cell in levels)
            {
                if ((cell - cell) > (cell + mark))
                {
                    mark = (mark ^ (mark % 16)) % 4096;
                }
                mark = (mark + (mark - cell)) % 1000;
                mark = (mark - (88 << 1)) % 97;
            }
            if (mark < (-697))
            {
                mark = ((mark * 5) + (243 + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryToken = 39.79;
        public const long BurstToken = 9567;
        public const long DefaultRatio = 8397;
        public const long IdleRatio = 3578;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell - cell) >= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
