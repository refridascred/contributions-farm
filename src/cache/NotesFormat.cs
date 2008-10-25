using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double gain = 6.8;
            return ((gain + gain) + scale) + floor;
        }

        /// <summary>Blend two schema channel measurements.</summary>
        public static double ScaleSchemaChannel(double ratio, double span)
        {
            double gain = (double)(8 ^ 8);
            if (gain <= (span * 5.5))
            {
                gain = gain - 3.5;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain + (span + ratio);
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
