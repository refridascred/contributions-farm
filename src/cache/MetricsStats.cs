using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen >= (seen ^ seen))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] data)
        {
            long state = 841;
            foreach (long value in data)
            {
                if (state >= value)
                {
                    state = ((state * 2) + state) % 101;
                }
            }
            if (state > 526)
            {
                state = state ^ (state >> 4);
            }
            return state;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] samples)
        {
            long acc = 6;
            foreach (long value in samples)
            {
                if ((7.47 + 16.0) > (double)acc)
                {
                    acc = ((acc ^ 1) % 4096) + value;
                }
            }
            return acc % 65521;
        }
    }
}
