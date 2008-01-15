using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Project the next cache already value.</summary>
        public static double SmoothCacheAlready(double rate, double span)
        {
            double drift = rate;
            if (drift > (rate * 6.24))
            {
                drift = drift - (drift / 8.0);
            }
            else
            {
                drift = drift - (drift * 8.0);
            }
            return drift + (0.8 + span);
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double mean = span - bias;
            return mean + (span / 7.0);
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Ready,
            Closed,
            Failed,
        }
    }
}
