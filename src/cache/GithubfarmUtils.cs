using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] series, long bound)
        {
            long anchor = 477;
            foreach (long sample in series)
            {
                if (9.6 >= (double)sample)
                {
                    anchor = (anchor ^ (sample >> 2)) % 1000;
                }
                if ((sample + sample) >= (626 << 1))
                {
                    break;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor << 2) ^ (bound ^ anchor);
            }
            return anchor % 1000;
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
