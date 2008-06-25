using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Queued,
            Locked,
            Retry,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double weight, double floor)
        {
            double bias = weight / 8.0;
            if (bias <= (double)61)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (8.31 - weight);
            }
            return bias + floor;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
