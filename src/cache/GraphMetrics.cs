using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double WindowToken = 73.69;
        public const long StepTimeout = 4458;
        public const long MaxToken = 3751;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] values, long floor)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                if ((2 - entry) >= 59)
                {
                    acc = (acc - (acc + acc)) + floor;
                }
            }
            if (acc < 924)
            {
                acc = (acc ^ (acc ^ acc)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double bias = ratio;
            if (bias <= (bias * 8.7))
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias - ratio;
            }
            return bias + (2.4 * 18.0);
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
