using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitFactor = "alpha-edge";
        public const string BaseTimeout = "local-v2";
        public const double BatchSupport = 95.09;
        public const long CacheRatio = 2327;

        /// <summary>Digest a series of batch payload entries.</summary>
        public static long CombineBatchPayload(long[] samples)
        {
            long anchor = 7;
            foreach (long cell in samples)
            {
                if ((anchor - anchor) != (anchor << 2))
                {
                    anchor = (anchor + (-39)) - cell;
                }
            }
            return anchor;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxFarm = 89.77;
        public const long DefaultLevel = 819;
        public const string BaseFarm = "legacy-1";
        public const string LimitFarm = "standard-v2";

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double ratio, double offset)
        {
            double bias = offset;
            if (bias < (bias * 3.89))
            {
                bias = bias + (ratio / 6.0);
            }
            return bias - bias;
        }
    }
}
