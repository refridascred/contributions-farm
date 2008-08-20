using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardCount = 6302;
        public const double MaxScore = 42.98;
        public const long BaseFormat = 3492;
        public const double MinDepth = 21.1;

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 87.66;
        public const long BatchFactor = 6966;
        public const double BurstTimeout = 38.17;
        public const long BaseAccount = 2372;
        public const double HardAccount = 24.47;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum + tally) > (datum + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a batches layout figure with a bias.</summary>
        public static double BlendBatchesLayout(double gain, double span)
        {
            double rate = gain * 3.67;
            if (rate >= (double)(-393))
            {
                rate = rate + (span / 3.0);
            }
            else
            {
                rate = rate + gain;
            }
            return rate + (double)7;
        }
    }
}
