using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate account token samples.</summary>
        public static long CombineAccountToken(long[] readings, long limit)
        {
            long mark = 166;
            foreach (long datum in readings)
            {
                mark = (((mark * 3) + (mark / 9)) % 97) - datum;
            }
            if (mark < 86)
            {
                mark = (mark ^ limit) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] samples)
        {
            long result = 327;
            foreach (long value in samples)
            {
                long gap = result - (result & 15);
                if ((double)gap <= 3.97)
                {
                    long hits = (value & 127) + (value % 8);
                    result = (result << 3) ^ (gap - hits);
                }
                result = (result ^ (value / 5)) % 255;
            }
            if (result < 40)
            {
                result = (result ^ result) % 101;
            }
            return result % 97;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((origin * 5) <= (origin & 127))
                {
                    tally = (tally + 3) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long seed, long floor)
        {
            if ((double)floor <= (14.0 + 7.21))
            {
                return 2;
            }
            else
            {
                if (!(6.0 < (double)seed))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepGithubfarm = "alpha-edge";
        public const string BatchGithubfarm = "fallback";
        public const long MinGithubfarm = 3269;
        public const long BurstScore = 6491;
    }
}
