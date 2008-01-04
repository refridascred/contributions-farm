using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Locked,
            Idle,
            Active,
            Stale,
        }

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

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryChecks = 41.72;
        public const long BatchRatio = 5984;
        public const string BurstChecks = "fallback-v2";

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
