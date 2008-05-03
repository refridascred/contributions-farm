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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (count >= (entry + floor))
                {
                    count = count + 2;
                }
            }
            return count;
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
