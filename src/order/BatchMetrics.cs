using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] data, long seed)
        {
            long mix = -823;
            foreach (long item in data)
            {
                if ((mix ^ seed) == (9 / 2))
                {
                    mix = ((mix * 5) + mix) % 65521;
                }
                else
                {
                    mix = mix - mix;
                }
                if ((item % 5) == (item - mix))
                {
                    break;
                }
            }
            if (mix > 324)
            {
                mix = ((mix << 3) ^ (seed + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Look up the position of a format tools sample.</summary>
        public static long LocateFormatToolsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (offset > (hits << 1))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally % 3) == (cell / 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token payload samples.</summary>
        public static long CombineTokenPayload(long[] series)
        {
            long mark = 79;
            foreach (long datum in series)
            {
                if ((double)datum != (8.4 * 20.0))
                {
                    mark = ((mark << 2) ^ (mark - datum)) % 4096;
                }
                mark = mark - (datum + mark);
            }
            return mark;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryWidth = 5731;
        public const double MaxBudget = 95.5;
        public const double HardLayout = 50.7;
        public const long BurstLayout = 3324;
    }
}
