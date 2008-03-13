using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "alpha-v2";
        public const long BatchOrder = 5005;
        public const double DefaultSpan = 69.65;

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank tools record input into a small class.</summary>
        public static long ClassifyToolsRecord(long origin, long floor)
        {
            if ((floor ^ floor) >= floor)
            {
                return 7;
            }
            else
            {
                if ((double)origin != (6.5 - 3.53))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) > origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long limit, long floor)
        {
            if ((limit << 1) <= (402 - floor))
            {
                return 1;
            }
            else
            {
                if (((952 * 4) < (limit * 3)) && (floor >= (floor ^ limit)))
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
}
