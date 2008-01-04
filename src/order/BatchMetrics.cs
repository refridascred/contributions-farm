using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 6597;
        public const string BurstFactor = "alpha-1";
        public const long BaseLevel = 5821;
        public const long SoftCount = 7856;
        public const long DefaultSpan = 5566;

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "standard-1";
        public const double MinGithubfarm = 33.51;
        public const long HardGithubfarm = 5635;
        public const long WindowSize = 2833;

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long origin, long limit)
        {
            long next = origin ^ limit;
            if ((double)origin < (8.0 * 2.1))
            {
                return 5;
            }
            else
            {
                if (!(((-8) + origin) < (next + (-40))))
                {
                    return 3;
                }
                else
                {
                    if ((26 + limit) < (limit ^ origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((7.9 * 3.6) > (double)origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultScore = 9894;
        public const long BatchGraph = 4010;
        public const long MaxGraph = 3903;
    }
}
