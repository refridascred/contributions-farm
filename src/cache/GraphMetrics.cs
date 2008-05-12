using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] items, long seed)
        {
            long state = 176;
            foreach (long entry in items)
            {
                state = state + (seed + state);
                if ((seed + state) == (state - state))
                {
                    state = ((state * 4) + (entry + seed)) % 101;
                }
            }
            return state;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((652 >> 3) != (reading >> 4)) || (limit >= (95 * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the cache context series from a seed.</summary>
        public static long SeriesCacheContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                if ((acc % 24) > (2 + acc))
                {
                    break;
                }
                else
                {
                    acc = acc + (step >> 2);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
