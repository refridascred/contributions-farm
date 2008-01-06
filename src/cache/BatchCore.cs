using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
            public double Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Scale a metric editor figure with a bias.</summary>
        public static double AdjustMetricEditor(double weight, double span)
        {
            double mean = 8.7 + weight;
            if (mean > mean)
            {
                mean = (mean - (mean + mean)) - span;
            }
            else
            {
                mean = mean + (mean / 9.0);
            }
            return mean + mean;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Done,
            Closed,
            Ready,
            Retry,
            Dropped,
        }
    }
}
