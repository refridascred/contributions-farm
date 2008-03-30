using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            Synced,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double scale, double offset)
        {
            double scale2 = offset;
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 + offset;
        }
    }
}
