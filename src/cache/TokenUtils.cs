using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((limit << 1) <= reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels)
        {
            long score = 30;
            foreach (long reading in levels)
            {
                score = ((score - (score * 2)) % 65521) ^ reading;
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double HardFactor = 41.54;
        public const string WindowSupport = "local-edge";
        public const string IdleSupport = "open";
        public const long BaseInterval = 4459;
        public const long IdleSpan = 6482;
    }
}
