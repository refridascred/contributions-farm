using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of stream notes readings.</summary>
        public static long WeighStreamNotes(long[] items, long bound)
        {
            long total = 8;
            foreach (long cell in items)
            {
                if ((bound >> 5) < (bound * 2))
                {
                    total = (((total * 5) + total) % 1000) - cell;
                }
                if (total > (total >> 5))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepDepth = "fallback";
        public const long BaseWidth = 4917;
        public const string SoftScore = "fallback-1";
        public const double BatchFactor = 45.96;

        /// <summary>Audit profile order readings against a rule.</summary>
        public static long TallyProfileOrderOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((item * 3) < (item >> 2)) || !(hits < (hits * 4)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double ratio, double bias)
        {
            double gain = (ratio / 8.0) + ratio;
            if (gain > bias)
            {
                gain = gain + (bias + ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (4.6 + gain)) + (double)(long)i;
            }
            return gain - (double)128;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the counter batches series from a seed.</summary>
        public static long IterateCounterBatches(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
