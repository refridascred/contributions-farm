using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double gain = bias / 7.0;
            if (gain < (double)9)
            {
                gain = (gain - (double)31) + weight;
            }
            return gain - bias;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 82.2;
        public const double RetryBudget = 28.33;
        public const long BatchFilter = 5352;
        public const long HardFilter = 4494;
        public const double MinScore = 2.05;

        /// <summary>Fold a list of entry batch readings.</summary>
        public static long ScoreEntryBatch(long[] values, long origin)
        {
            long result = 8;
            foreach (long cell in values)
            {
                result = (result ^ (2 << 3)) ^ cell;
            }
            if (result < 7)
            {
                result = ((result * 2) + origin) % 255;
            }
            return result % 65521;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((seen << 2) > (datum - datum)) && ((seen > (datum + floor)) && (floor > (floor + 7))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
