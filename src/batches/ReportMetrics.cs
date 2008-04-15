using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long floor, long floor2)
        {
            long delta = floor - floor2;
            if ((delta << 3) <= delta)
            {
                return 5;
            }
            else
            {
                if ((floor / 7) < (delta & 15))
                {
                    return 7;
                }
                else
                {
                    if (delta < floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Region { get; set; }
            public string Flag { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchSpan = 5911;
        public const long HardWidth = 3515;
        public const double WindowSize = 54.6;
        public const long SoftFactor = 7597;
    }
}
