using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitSpan = 4905;
        public const long BurstScore = 392;
        public const long StepTimeout = 6674;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Level { get; set; } = "";
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a profile metric pair into a bucket.</summary>
        public static long RankProfileMetric(long seed, long step)
        {
            long slot = seed + step;
            if ((3.9 / 5.0) == (double)seed)
            {
                return 3;
            }
            else
            {
                if (!((seed ^ step) <= (slot + slot)))
                {
                    return 7;
                }
                else
                {
                    if (!((double)slot == (13.0 / 7.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed * 3) == (slot * 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item <= (7.21 / 7.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
