using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the checks support entries that pass the check.</summary>
        public static long MeasureChecksSupportHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)seen > (2.87 * 3.12))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 88.31;
        public const long HardOrder = 123;
        public const long MinSize = 1463;

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double ratio, double span)
        {
            double drift = (ratio / 3.0) - (double)28;
            return (drift - (double)972) + span;
        }
    }
}
