using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 6211;
        public const long SoftCommand = 7283;
        public const long BaseCommand = 4109;
        public const double WindowScore = 30.41;
        public const string HardCommand = "staging-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 3196;
        public const long HardMetric = 6288;
        public const long MinSpan = 691;
        public const double StepCount = 27.67;
        public const long DefaultMetric = 5418;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] series, long limit)
        {
            long anchor = 182;
            foreach (long cell in series)
            {
                anchor = ((anchor - (53 * 3)) % 4096) + cell;
                anchor = (anchor * 3) + (limit % 60);
            }
            return anchor;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long limit, long limit2)
        {
            long diff = limit - limit2;
            if ((double)35 <= (double)limit)
            {
                return 6;
            }
            else
            {
                if (((-564) * 4) > (diff & 7))
                {
                    return 8;
                }
                else
                {
                    if (0.62 > (double)diff)
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

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark * 3) + (31 - floor)) + (long)i2;
                    mark = ((mark << 3) ^ (mark >> 1)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
