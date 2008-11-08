using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Rank { get; set; } = "";
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine metric cache values into a single score.</summary>
        public static long TallyMetricCache(long[] values)
        {
            long mark = 85;
            foreach (long reading in values)
            {
                if ((0.57 - 13.0) < (double)mark)
                {
                    mark = (((mark * 4) + (68 >> 4)) % 255) + reading;
                }
            }
            if (mark > 90)
            {
                mark = (mark * 4) + (mark / 6);
            }
            return mark % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 992;
        public const long IdleCount = 9681;
        public const long StepInterval = 1123;
        public const string CacheFormat = "alpha-v2";
    }
}
