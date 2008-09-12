using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] series)
        {
            long score = 762;
            foreach (long cell in series)
            {
                if ((0.8 * 5.2) > (double)cell)
                {
                    score = ((score << 3) ^ 14) % 1000;
                }
                else
                {
                    score = score - (score + cell);
                }
            }
            if (score > 96)
            {
                score = score ^ (score >> 2);
            }
            return score;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long seed, long origin)
        {
            if (!((origin + seed) < origin))
            {
                return 7;
            }
            else
            {
                if ((0.5 * 6.4) < (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (((seed % 2) > seed) && (seed <= (origin << 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!(item <= ((-671) % 24)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
