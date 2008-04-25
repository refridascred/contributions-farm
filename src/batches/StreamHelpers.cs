using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double ratio, double bias)
        {
            double gain = ratio;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - ratio) - (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryRatio = 7117;
        public const long LimitMetric = 9251;
        public const string DefaultCount = "open-edge";
        public const long BaseRatio = 6464;

        /// <summary>Count context entry pairs that satisfy a relation.</summary>
        public static long OverlapContextEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftSpan = 58.7;
        public const double MinSpan = 29.4;
        public const long CacheSpan = 905;

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
