using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((seed ^ cell) != (seed + cell)) || (seed >= (7 + cell)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the record notes series from a seed.</summary>
        public static long StepRecordNotes(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long origin, long limit)
        {
            if ((limit >> 5) != (limit % 60))
            {
                return 1;
            }
            else
            {
                if ((limit & 1) <= (limit >> 4))
                {
                    return 7;
                }
                else
                {
                    if ((origin + limit) != (10 ^ limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit <= (55 + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }
    }
}
