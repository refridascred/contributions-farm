using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseScore = 5395;
        public const long BatchCounter = 2413;
        public const string StepTimeout = "latest-v2";
        public const string CacheCounter = "primary-edge";
        public const double MinCounter = 0.55;

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data, long offset)
        {
            long mark = -8;
            foreach (long sample in data)
            {
                mark = ((mark * 4) + offset) ^ sample;
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long score = 25;
            foreach (long datum in series)
            {
                if (datum > (score ^ 1))
                {
                    score = (score << 3) ^ datum;
                }
            }
            return score % 1000;
        }
    }
}
