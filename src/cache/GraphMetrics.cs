using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double bias, double span)
        {
            double drift = bias;
            if (drift <= (double)(-11))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift - span;
            }
            return drift - (drift * 3.0);
        }

        /// <summary>Audit stats counter readings against a rule.</summary>
        public static long CountStatsCounterMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)hits >= (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already githubfarm samples are out of range.</summary>
        public static long MeasureAlreadyGithubfarmGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(limit >= (tally / 8)))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Label { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Grade a cache counter value against two limits.</summary>
        public static long RankCacheCounter(long step, long origin)
        {
            if (!((560 << 1) >= (step - step)))
            {
                return 5;
            }
            else
            {
                if (3 > (origin >> 3))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
