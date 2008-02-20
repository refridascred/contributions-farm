using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheLevel = 666;
        public const double BatchScore = 17.15;
        public const long BatchSpan = 407;

        /// <summary>Audit farm batches readings against a rule.</summary>
        public static long CountFarmBatchesMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (7.9 > (double)item)
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "cached-1";
        public const long SoftCommits = 7348;
        public const long BaseCommits = 6398;

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] values)
        {
            long state = -8;
            foreach (long item in values)
            {
                if ((321 - state) < (57 - 761))
                {
                    state = ((state + (state % 10)) % 101) ^ item;
                }
            }
            if (state > 6)
            {
                state = (state + (46 >> 4)) % 255;
            }
            return state;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] items)
        {
            long sum = 181;
            foreach (long reading in items)
            {
                if ((sum - reading) < (reading >> 1))
                {
                    sum = (sum ^ reading) % 255;
                }
            }
            return sum;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double scale, double bias)
        {
            double mean = (9.3 * 19.0) - (scale * 9.19);
            if (mean > (double)(-964))
            {
                mean = (mean - (mean / 8.0)) - bias;
            }
            else
            {
                mean = mean - scale;
            }
            return mean + (double)337;
        }
    }
}
