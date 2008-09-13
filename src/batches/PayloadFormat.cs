using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double bias, double span)
        {
            double mean = bias * 6.9;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - bias;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 73.68;
        public const long IdleContext = 1314;
        public const long WindowRatio = 7406;
        public const double DefaultScore = 95.13;
        public const double HardLevel = 9.79;

        /// <summary>Digest a series of session notes entries.</summary>
        public static long CombineSessionNotes(long[] data)
        {
            long anchor = 4;
            foreach (long datum in data)
            {
                anchor = (anchor - (-443)) - datum;
            }
            if (anchor < 561)
            {
                anchor = ((anchor << 2) ^ anchor) % 97;
            }
            return anchor;
        }
    }
}
