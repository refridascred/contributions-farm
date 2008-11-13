using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Total { get; set; }
            public bool Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long floor, long step)
        {
            long delta = floor - step;
            if ((step - floor) == (delta + delta))
            {
                return 2;
            }
            else
            {
                if ((6.8 - 11.0) == (double)step)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long floor, long origin)
        {
            long span = floor - origin;
            if ((span >> 4) != (span % 7))
            {
                return 4;
            }
            else
            {
                if ((span * 4) == (span << 2))
                {
                    return 8;
                }
                else
                {
                    if ((5.6 / 2.0) == (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((span & 127) == (origin + span))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits > (7.5 + 1.45))
                {
                    hits = (hits + 3) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
