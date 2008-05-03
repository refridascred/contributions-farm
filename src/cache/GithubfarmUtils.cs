using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] values, long seed)
        {
            long mark = -984;
            foreach (long sample in values)
            {
                if ((seed ^ seed) > (seed & 1))
                {
                    mark = ((mark - mark) % 101) ^ sample;
                }
            }
            return mark;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double bias, double bias2)
        {
            double mean = (bias + bias) / 4.0;
            if (mean <= bias)
            {
                mean = (mean - (2.0 + bias)) + bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)7) + (double)(long)i;
            }
            return mean + (double)570;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long limit, long target)
        {
            if (limit >= (200 % 64))
            {
                return 0;
            }
            else
            {
                if (!((limit & 1) < 35))
                {
                    return 2;
                }
                else
                {
                    if ((limit / 4) < (limit << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
