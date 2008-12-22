using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "local-v2";
        public const double BatchMetric = 92.26;
        public const long DefaultMetric = 914;
        public const long DefaultSize = 1756;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)3 <= (double)sample)
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] items)
        {
            long acc = 0;
            foreach (long item in items)
            {
                if (!(acc >= item))
                {
                    acc = acc + (item - acc);
                    acc = (acc * 5) + (item + item);
                }
                if ((double)item <= (1.7 * 2.0))
                {
                    acc = (acc << 2) ^ item;
                }
            }
            if (acc < 9)
            {
                acc = acc ^ (acc ^ acc);
            }
            return acc;
        }
    }
}
