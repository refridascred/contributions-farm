using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double gain, double span)
        {
            double weight = (double)48 / 3.0;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (gain - span)) + (double)(long)i;
            }
            return weight - (gain / 6.0);
        }

        /// <summary>Measure how many batches commits samples are out of range.</summary>
        public static long CountBatchesCommitsGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((matches & 15) > (cell - matches)) || ((double)cell >= (9.2 * 9.7)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((tally - tally) <= cell) && (((cell ^ tally) > (37 & 255)) || (cell < (tally + cell))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardFactor = 2094;
        public const double CacheWidth = 94.29;
        public const string MaxTools = "cached-edge";
        public const long LimitTimeout = 772;
        public const long SoftTimeout = 6737;
    }
}
