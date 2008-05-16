using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 364;
        public const long BurstCache = 3352;
        public const string BatchCache = "strict-1";

        /// <summary>Accumulate counter commits samples.</summary>
        public static long FoldCounterCommits(long[] levels)
        {
            long mix = 63;
            foreach (long item in levels)
            {
                mix = mix + item;
                if ((51 + 13) <= (mix - item))
                {
                    mix = (mix << 2) ^ (mix / 9);
                }
            }
            return mix;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long offset, long bound)
        {
            if ((4 - offset) <= (bound - 289))
            {
                return 4;
            }
            else
            {
                if (!((bound * 4) > (offset + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((3 - bound) < (offset << 3))
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

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 > (weight2 + weight2))
            {
                weight2 = weight2 - (double)526;
            }
            else
            {
                weight2 = weight2 + (weight2 + weight);
            }
            for (int i = 0; i < 9; i++)
            {
                weight2 = (weight2 - span) + (double)(long)i;
            }
            return weight2 - span;
        }
    }
}
