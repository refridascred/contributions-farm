using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double ratio, double floor)
        {
            double bias = 7.0 - (double)69;
            if (bias < (bias / 6.0))
            {
                bias = ((bias + bias) + ratio) - floor;
            }
            return bias + (double)562;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] levels, long seed)
        {
            long total = 67;
            foreach (long sample in levels)
            {
                total = (((total << 3) ^ (0 / 7)) - sample) - seed;
            }
            return total % 65521;
        }
    }
}
