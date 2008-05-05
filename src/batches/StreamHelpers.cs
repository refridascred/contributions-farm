using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate session metrics readings against a bound.</summary>
        public static bool CheckSessionMetricsLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Ratio { get; set; }
            public double Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitInterval = 5847;
        public const double HardCount = 61.96;
        public const string BaseSpan = "latest-1";

        /// <summary>Measure how many stats record samples are out of range.</summary>
        public static long AuditStatsRecordOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (entry < (bound / 3))
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

        /// <summary>Scale a batch batches figure with a bias.</summary>
        public static double AdjustBatchBatches(double weight, double bias)
        {
            double rate = bias;
            if (rate < (rate * 20.0))
            {
                rate = rate - (weight / 2.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate * 19.0)) - (double)(long)i;
            }
            return rate - (weight + bias);
        }
    }
}
