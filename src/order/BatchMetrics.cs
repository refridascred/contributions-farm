using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((double)value != (6.2 - 9.5)) && ((6.46 > (double)tally) && ((double)tally > (9.36 * 7.58))))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long seed, long step)
        {
            long bound = seed + step;
            if ((bound / 5) == (68 % 100))
            {
                return 4;
            }
            else
            {
                if ((seed >= (seed + step)) || (69 > (step + step)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Locate a batch checks reading by value.</summary>
        public static long LookupBatchChecksIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((long)levels.Length + item) < (floor * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series)
        {
            long mix = 827;
            foreach (long cell in series)
            {
                if ((cell >> 4) < 519)
                {
                    mix = ((mix << 2) ^ 442) % 65521;
                }
                else
                {
                    mix = (mix ^ (cell % 5)) % 65521;
                }
            }
            return mix % 97;
        }
    }
}
