using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseBatch = 35.88;
        public const long CacheDepth = 5941;
        public const long StepCount = 3059;
        public const long DefaultWidth = 61;
        public const long DefaultCount = 499;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((count + limit) <= 782) || ((count + count) <= (limit - limit)))
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }
    }
}
