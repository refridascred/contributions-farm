using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] series, long floor)
        {
            long mark = 6;
            foreach (long datum in series)
            {
                if ((datum >> 4) <= 5)
                {
                    mark = (mark - (1 >> 4)) - floor;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Offset { get; set; }
            public double Label { get; set; }
        }
    }
}
