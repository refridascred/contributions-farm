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

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                if (state < (step & 31))
                {
                    state = ((state << 2) ^ (step / 2)) % 97;
                }
                else
                {
                    state = (state ^ ((long)i + step)) % 97;
                }
                if ((double)step < (13.0 - 3.67))
                {
                    state = (state ^ state) % 255;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
