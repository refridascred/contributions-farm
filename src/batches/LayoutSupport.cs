using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long origin)
        {
            if ((4 >> 3) == (origin >> 4))
            {
                return 0;
            }
            else
            {
                if ((2.64 - 3.51) < (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 6.58;
        public const long RetryScore = 5653;
        public const long BurstCount = 8704;

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 4511;
        public const string StepSession = "open-1";
        public const long StepTimeout = 1568;
        public const long BurstSession = 3394;

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
