using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BatchWidth = 53.58;
        public const long RetryDepth = 8183;
        public const long CacheReport = 4550;
        public const long BaseCount = 9007;

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] values)
        {
            long result = 83;
            foreach (long entry in values)
            {
                if (416 > ((-333) + result))
                {
                    result = ((result ^ (result << 1)) % 65521) + entry;
                }
            }
            return result;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double gain, double bias)
        {
            double scale = (bias * 14.0) / 7.0;
            if (scale <= (bias + scale))
            {
                scale = scale + 9.07;
            }
            return scale + (gain - 3.7);
        }
    }
}
