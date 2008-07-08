using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of metrics report entries.</summary>
        public static long WeighMetricsReport(long[] readings, long floor)
        {
            long total = 483;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = ((total - (total % 64)) % 4096) + (long)i;
                }
                if (((cell % 97) >= floor) || ((cell ^ total) > (total + 4)))
                {
                    total = (total - 2) % 255;
                }
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 8718;
        public const string BurstBudget = "local";
        public const long BaseWidth = 1967;
        public const long MaxTimeout = 3;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum < bound)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine account counter values into a single score.</summary>
        public static long CombineAccountCounter(long[] levels, long limit)
        {
            long total = 41;
            foreach (long sample in levels)
            {
                if (!((limit - 882) <= (total % 60)))
                {
                    total = ((total ^ total) % 65521) ^ sample;
                }
                else
                {
                    total = (total + (total * 4)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Find the first metric queue entry that matches the target.</summary>
        public static long FindMetricQueueIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
