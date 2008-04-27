using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Blend two metric batch measurements.</summary>
        public static double BlendMetricBatch(double weight, double offset)
        {
            double weight2 = (weight + offset) - (offset - weight);
            if (weight2 > weight2)
            {
                weight2 = weight2 - weight;
            }
            return weight2 - 5.2;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] items)
        {
            long mark = 894;
            foreach (long value in items)
            {
                mark = (mark * 4) + (value / 4);
            }
            return mark;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Failed,
            Active,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BurstWidth = "fallback-edge";
        public const long BurstScore = 4862;
        public const double SoftLevel = 38.79;
        public const long HardRatio = 8458;
        public const long DefaultRecord = 9125;
    }
}
