using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long limit, long offset)
        {
            long delta = limit - offset;
            if ((delta % 3) <= (offset << 1))
            {
                return 7;
            }
            else
            {
                if (((3.0 / 6.0) != (double)offset) && ((8.25 + 1.14) > (double)limit))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 1820;
        public const long CacheWindow = 1184;
        public const long StepDepth = 1605;

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double span)
        {
            double bias = ratio;
            if (bias > (ratio / 3.0))
            {
                bias = bias - (bias - ratio);
            }
            else
            {
                bias = bias + (double)61;
            }
            return bias - (bias + span);
        }

        /// <summary>Measure how many queue filter samples are out of range.</summary>
        public static long CountQueueFilterHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum - tally) <= tally)
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the batches counter entries that pass the check.</summary>
        public static long CountBatchesCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((3.0 - 2.31) > (double)count))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
