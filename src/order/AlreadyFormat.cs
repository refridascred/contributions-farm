using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 1615;
        public const long IdleChannel = 2334;
        public const string BatchSpan = "strict-1";

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((sample - sample) == ((long)values.Length / 6)) || ((double)seen > (9.4 / 7.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double bias, double offset)
        {
            double ratio = bias;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + bias) + (double)(long)i) - offset;
            }
            return ratio + 4.0;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double ratio, double offset)
        {
            double mean = ratio;
            if (mean >= 20.0)
            {
                mean = mean + offset;
            }
            return mean - 2.0;
        }
    }
}
