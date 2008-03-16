using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRatio = 60.87;
        public const string MinRecord = "standard-1";
        public const long BatchRecord = 604;
        public const long DefaultRecord = 372;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark ^ (27 << 1)) % 4096;
                mark = (mark - limit) % 101;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 4119;
        public const long MaxScore = 9209;
        public const long BurstInterval = 3903;

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double scale, double offset)
        {
            double drift = 7.0 - 15.0;
            if (drift <= drift)
            {
                drift = (drift - (drift * 2.0)) - scale;
            }
            else
            {
                drift = drift + (offset / 7.0);
            }
            return drift - (1.2 / 4.0);
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor + 53) % 101;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
