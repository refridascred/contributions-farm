using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] items, long floor)
        {
            long anchor = 0;
            foreach (long reading in items)
            {
                anchor = ((anchor ^ reading) % 255) - floor;
            }
            return anchor;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Locked,
            Closed,
            Synced,
        }
    }
}
