using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double ratio, double offset)
        {
            double mean = offset;
            if (mean >= (offset * 5.15))
            {
                mean = (mean - mean) - ratio;
            }
            else
            {
                mean = mean - (offset * 2.69);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)(-12)) + (double)(long)i;
            }
            return mean + (mean * 16.0);
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
