using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels)
        {
            long sum = 155;
            foreach (long sample in levels)
            {
                if ((sample * 3) <= 1)
                {
                    sum = sum - sum;
                }
            }
            return sum;
        }

        /// <summary>Find the first cache queue entry that matches the target.</summary>
        public static long LookupCacheQueueIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics batch entries that pass the check.</summary>
        public static long CountMetricsBatchMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length + datum) == (955 + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= (double)9)
            {
                weight = (weight - (double)427) - floor;
            }
            return weight + (double)0;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
