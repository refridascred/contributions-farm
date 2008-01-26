using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long target)
        {
            long edge = floor + target;
            if (((floor / 8) >= floor) && ((floor + edge) <= (84 + target)))
            {
                return 1;
            }
            else
            {
                if ((target % 8) <= (edge ^ edge))
                {
                    return 8;
                }
                else
                {
                    if (((edge + floor) > (20 + target)) || ((double)edge <= (2.63 / 8.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Mode { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleFactor = 59.53;
        public const long BaseCommits = 6133;
        public const double SoftCommits = 86.05;
        public const long DefaultCommits = 894;
        public const long CacheScore = 1789;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Weight { get; set; } = "";
            public double Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
