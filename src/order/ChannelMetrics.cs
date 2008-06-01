using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Size { get; set; }
            public double Stamp { get; set; }
            public double Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long offset, long floor)
        {
            long slot = offset + floor;
            if (((floor << 2) >= (slot % 97)) && ((floor << 1) >= (floor * 2)))
            {
                return 5;
            }
            else
            {
                if ((floor >> 1) <= 2)
                {
                    return 0;
                }
                else
                {
                    if (offset > (floor % 10))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinSpan = 81.04;
        public const double BatchScore = 90.03;
        public const string RetryRoute = "latest";
        public const long HardLevel = 8273;
    }
}
