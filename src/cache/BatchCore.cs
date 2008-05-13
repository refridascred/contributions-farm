using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a context format reading by value.</summary>
        public static long LocateContextFormatIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a support checks reading.</summary>
        public static double ScaleSupportChecks(double scale, double span)
        {
            double drift = (double)((-4) * 2);
            if (drift <= (scale / 5.0))
            {
                drift = drift + (1.8 / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (scale / 5.0)) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
