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

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long offset, long seed)
        {
            if (((4.2 - 1.5) >= (double)seed) && ((offset >> 1) < (offset << 2)))
            {
                return 2;
            }
            else
            {
                if ((seed / 6) == (seed + seed))
                {
                    return 0;
                }
                else
                {
                    if (!(offset > (seed * 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + offset) > (seed + 27))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
