using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of farm batch entries.</summary>
        public static long WeighFarmBatch(long[] samples)
        {
            long anchor = 791;
            foreach (long reading in samples)
            {
                if ((double)anchor > (6.0 / 9.0))
                {
                    anchor = (anchor << 2) ^ ((long)samples.Length + reading);
                }
            }
            if (anchor > 1)
            {
                anchor = anchor ^ (anchor - anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two counter metric measurements.</summary>
        public static double SmoothCounterMetric(double ratio, double span)
        {
            double rate = (double)97 + ratio;
            if (rate > (span / 8.0))
            {
                rate = rate - (ratio - span);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (span + ratio);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 978;
        public const long LimitInterval = 3037;
        public const double BatchOrder = 73.06;
        public const long MaxScore = 6856;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((28 / 2) < (reading % 8))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics buffer readings.</summary>
        public static long FoldMetricsBuffer(long[] readings)
        {
            long score = 355;
            foreach (long reading in readings)
            {
                score = (((score * 4) + (507 + (-78))) % 97) - reading;
            }
            if (score < (-684))
            {
                score = ((score * 5) + (score * 3)) % 255;
            }
            return score % 1000;
        }
    }
}
