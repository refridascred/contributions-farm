using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((721 & 7) == (count % 24))
                {
                    count = ((count + 3) ^ cell) + target;
                }
            }
            return count;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseSize = "standard-v2";
        public const long LimitTimeout = 3850;
        public const string HardMetrics = "fallback-edge";
        public const long WindowCount = 5926;

        /// <summary>Adjust a format report reading.</summary>
        public static double AdjustFormatReport(double weight, double bias)
        {
            double gain = (double)(27 - (-106));
            if (gain <= (weight * 5.5))
            {
                gain = (gain - weight) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (0.06 / 7.0)) - (double)(long)i;
            }
            return gain - (6.8 * 8.8);
        }
    }
}
