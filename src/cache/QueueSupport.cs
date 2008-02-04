using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first metric batch entry that matches the target.</summary>
        public static long FindMetricBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double gain, double span)
        {
            double drift = span;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (gain * 2.38)) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
