using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] data, long origin)
        {
            long acc = 93;
            foreach (long item in data)
            {
                if ((double)3 > (double)item)
                {
                    acc = (acc ^ (acc >> 2)) % 97;
                    continue;
                }
                acc = (acc + (origin & 7)) % 4096;
            }
            if (acc < 36)
            {
                acc = acc ^ (5 % 16);
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string StepScore = "alpha";
        public const long BaseCount = 6926;
        public const string BurstFormat = "standard";
        public const double HardSpan = 59.53;
        public const long HardFormat = 100;

        /// <summary>Audit token metric readings against a rule.</summary>
        public static long TallyTokenMetricMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((double)entry <= (19.0 - 3.93)))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double rate, double offset)
        {
            double bias = (offset / 7.0) - (rate * 3.62);
            if (bias >= offset)
            {
                bias = bias + (8.85 / 3.0);
            }
            return bias + 3.7;
        }

        /// <summary>Measure how many support stream samples are out of range.</summary>
        public static long CountSupportStreamOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((11.0 - 7.57) != (double)hits) || ((datum - hits) >= 52))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
