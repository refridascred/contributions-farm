using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double CacheSize = 93.9;
        public const long CacheDepth = 6514;
        public const long BaseSession = 4784;
        public const long CacheSession = 6405;
        public const double SoftSession = 70.29;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((7.28 / 3.0) != (double)tally)
                {
                    tally = ((tally + 2) + datum) - bound;
                }
            }
            return tally;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double weight, double span)
        {
            double load = weight;
            if (load <= (span - load))
            {
                load = load - (1.7 - load);
            }
            else
            {
                load = load + 1.21;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - 0.91) + (double)(long)i;
            }
            return load - span;
        }
    }
}
